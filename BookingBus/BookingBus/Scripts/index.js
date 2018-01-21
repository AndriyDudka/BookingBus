$(function () {

    $('#Mukachevo').on('click', function () {
        $('#from').val('Мукачево');
        $('#to').val('Ужгород');

        $('#date').val(todayFormat());
        $('#date').focus();
    });

    $('#Uzhhorod').on('click', function () {
        $('#to').val('Мукачево');
        $('#from').val('Ужгород');

        $('#date').val(todayFormat());
        $('#date').focus();
    });

    $('#Mouse').on('click', function () {
        $('#to').val('Пацканьово');
        $('#from').val('Крисовці');

        $('#date').val(todayFormat());
        $('#date').focus();
    });

    $('#UzhNU').on('click', function () {
        $('#to').val('Армія');
        $('#from').val('УжНУ');

        $('#date').val(todayFormat());
        $('#date').focus();

        alert('ТРЕБА БУЛО ЙТИ В АСПІРАНТУРУ!!!');
    });

    $('#Uzhhorod1').on('click', function () {
        $('#from').val('Ужгород');
    });

    $('#Mukachevo1').on('click', function () {
        $('#from').val('Мукачево');
    });

    $('#Kiev').on('click', function () {
        $('#from').val('Київ');
    });

    $('#Lviv').on('click', function () {
        $('#from').val('Львів');
    });

    $('#Odessa').on('click', function () {
        $('#from').val('Одеса');
    });

    $('#Uzhhorod2').on('click', function () {
        $('#to').val('Ужгород');
    });

    $('#Mukachevo2').on('click', function () {
        $('#to').val('Мукачево');
    });

    $('#Kiev2').on('click', function () {
        $('#to').val('Київ');
    });

    $('#Lviv2').on('click', function () {
        $('#to').val('Львів');
    });

    $('#Odessa2').on('click', function () {
        $('#to').val('Одеса');
    });

    $('#ButtonBuy').on('click', function () {
        var count = $('#PlacesCount').html().trim();
        $('#PlacesCount').html(parseInt(count) - 1);
    });

    function todayFormat() {
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1;
        var yyyy = today.getFullYear();

        if (dd < 10) dd = '0' + dd;
        if (mm < 10) mm = '0' + mm;
        today = yyyy + '-' + mm + '-' + dd;

        return today;
    }
});