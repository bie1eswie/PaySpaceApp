services = {
    calculateTax: "https://localhost:44392/api/Calculator"
};

function Post(url, parameters, successCallback) {
        $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(parameters),
            contentType: 'application/json;',
            dataType: 'json',
            success: successCallback,
            error: function (xhr, textStatus, errorThrown) {
                console.log('error');
            }
        });
}