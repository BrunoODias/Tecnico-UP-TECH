(function () {
    function removeToast(el) {
        if (el != null && typeof el.remove == 'function')
            el.remove();
    }
    function CreateToast(Title, Text, CssType) {
        var el =
            $(`<div class="toast show custom-toast">
                <div class="toast-head ${CssType}">
                    ${Title || ''}
                </div>
                <div class="toast-body">
                    ${Text || ''}
                </div>
            </div>`);

        $(document.body).append(el);
        setTimeout(() => {
            removeToast(el);
        },5000);
        $(el).on('click', function () {
            removeToast(el);
        });
    }
    const toast = {
        Info: function (Text, Title) {
            CreateToast(Title, Text, 'alert-primary');
        },
        Success: function (Text, Title) {
            CreateToast(Title, Text, 'alert-success');
        },
        Error: function (Text, Title) {
            CreateToast(Title, Text, 'alert-danger');
        }
    }
    window.Toast = toast;
})();
Object.freeze(Toast);


(function () {
    var KeyPressed = (keys, event) => (keys.find(x => x == event.originalEvent.key)) != null;

    const OnKeyPress = (keys,cb) => {
        if (keys == null || typeof cb != 'function')
            return;

        var _keys = [];
        if (Array.isArray(keys))
            _keys = keys;

        if (typeof keys == 'object' && keys.length == 0)
            return;
        else if (_keys.length == 0)
            _keys.push(keys);

        return new Promise(
            (resolve) => {
                $(document.body).on('keydown', (event) => {
                    if (KeyPressed(_keys, event))
                        cb();
                });
            }
        )
    }
    window.OnKeyPress = OnKeyPress;


    $('.favoriteToggle').on('click', function (event) {
        var favorited = $(this).attr('isfavorite') == 'true';
        var model = $(this).attr('model');
        var url = "/Account";
        if (favorited)
            url += "/RemoveFavorite";
        else
            url += "/AddFavorite";
        $.ajax({
            method: 'POST',
            url: url,
            data: JSON.parse(model),
            success: function (msg) {
                if (favorited) {
                    $(event.currentTarget).removeClass('favorited-book');
                    $(event.currentTarget).attr('isfavorite', false);
                }
                else {
                    $(event.currentTarget).addClass('favorited-book');
                    $(event.currentTarget).attr('isfavorite', true);
                }

                Toast.Success(msg);
                $.ajax({
                    url: "/home/RefreshLeftMenu",
                    success: function (html) {
                        $('#favoritesBlock').css('z-index', '999');
                        $('.leftMenu').removeClass('menu-open');
                        $('.toggleFavoritesMenu').removeClass('rotate');
                        setTimeout(function (e) {
                        $('#favoritesBlock').css('z-index', '-1');
                            $('.LeftMenuContainer')[0].innerHTML = html;
                        }, 1000);
                    },
                    error: window.location.reload
                });
            },
            error: function (msg) {
                Toast.Error(msg.responseText, 'Erro ao executar a ação');
            }
        });
    });
})();
Object.freeze(OnKeyPress);