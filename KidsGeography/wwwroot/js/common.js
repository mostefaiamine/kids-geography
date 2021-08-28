window.showToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Blazor app');
    }
    if (type === "error") {
        toastr.error(message, 'Blazor app');
    }
}

function showConfirm() {
    $("#deleteConfirmationModal").modal('show');
}

function hideConfirm() {
    $("#deleteConfirmationModal").modal('hide');
}