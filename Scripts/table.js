$(document).ready(function () {
    $('#example').DataTable({
        info: false,
        ordering: false,
        searching:false
    });
    $('#delete').on('hidden.bs.modal', function () {
        $('body').css('padding-right', '');
    });
});
