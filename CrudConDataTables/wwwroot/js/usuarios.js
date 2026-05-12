var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Usuarios/GetUsuarios"
        },
        "columns": [
            { "data": "nombre", "width": "25%" },
            { "data": "email", "width": "20%" },
            { "data": "telefono", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Usuarios/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer">
                                <i class="fas fa-edit"></i> Editar
                            </a>
                            <a onclick=Delete("/Usuarios/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
                                <i class="fas fa-trash-alt"></i> Borrar
                            </a>
                        </div>
                    `;
                }, "width": "35%"
            }
        ]
    });
}

function Delete(url) {
    if (confirm("¿Estás seguro de que quieres borrar este registro?")) {
        $.ajax({
            type: "DELETE",
            url: url,
            success: function (data) {
                if (data.success) {
                    dataTable.ajax.reload();
                    alert(data.message);
                }
                else {
                    alert(data.message);
                }
            }
        });
    }
}
