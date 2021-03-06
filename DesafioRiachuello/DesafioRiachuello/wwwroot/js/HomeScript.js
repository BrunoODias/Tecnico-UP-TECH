
document.addEventListener('DOMContentLoaded', function (e) {
    $('#Page').css('height', `${window.innerHeight}px`);
    $('#Page').css('max-height', `${window.innerHeight}px`);


    $('.leftMenu').css('height', `calc(${$('html').height()}px - ${$('.navbar').height()}px)`);

    document.getElementsByClassName('toggleFavoritesMenu')[0].addEventListener('click', function (e) {
        $(this).toggleClass('rotate');
        $('.leftMenu').toggleClass('menu-open');
        $('.LeftMenuContainer').toggleClass('menu-open');
    })

    $('.nav-link').on('click', function (event) {
        $('.nav-link.active').removeClass('active');
        $('.nav-link.active').css('border-bottom', 'none');
        $('.tab-pane.show.active').removeClass('show').removeClass('active').removeClass('d-flex');

        $(this).addClass('active');
        $(this).css('border-bottom', '#daf9ff');
        $(`#${this.getAttribute('aria-controls')}`).addClass('show').addClass('active').addClass('d-flex');
    });

    $('#TabContentSelector > li > a').first().click();

    (function () {
        var getSearch = () => {
            var term = $('#SearchTerm').val(), type = '';
            for (var current of document.getElementsByName('searchType')) {
                if (current.checked) {
                    type = current.value;
                }
            }

            var isNotValid = x => x == null || x == '';

            if (isNotValid(term) || isNotValid(type)) {
                Toast.Info('Digite um termo para a busca e selecione um tipo de busca', 'Observação');
                return;
            }

            var url = `/Search/Get${type}/${term}`;

            window.location.href = url;
        };

        $('#btnSearch').on('click', getSearch);
        OnKeyPress('Enter', getSearch);
    })();

}, false);