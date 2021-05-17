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
})();
Object.freeze(OnKeyPress);