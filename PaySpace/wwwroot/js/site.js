﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
function submitForm(form) {
    var formParams = $(form).serializeObject();
    Post(services.calculateTax, formParams, onSuccess)
}
function onSuccess(param) {
    console.log(param);
    $("#calculatedValue").text(`Yaur Annual tax is ${param.calculatedValue} and your total after tax is ${param.annualIncome - param.calculatedValue}`);
}
