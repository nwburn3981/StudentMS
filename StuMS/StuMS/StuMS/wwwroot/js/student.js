var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable()
{
    dataTable = $('#stu-tbl').DataTable({
        "ajax": {
            "url": "/Student/Student/GetAll"
        },
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "dob", "width": "15%" },
            { "data": "email", "width": "15%" }
        ]
    });
}