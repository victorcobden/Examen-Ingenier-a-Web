function comprobardatos() {
    var varCompanyName = document.getElementById("CompanyName").value;
    var varContactName = document.getElementById("ContactName").value;
    var varContactTitle = document.getElementById("ContactTitle").value;
    var varAddress = document.getElementById("Address").value;
    var varCity = document.getElementById("City").value;
    var varRegion = document.getElementById("Region").value;
    var varPostalCode = document.getElementById("PostalCode").value;
    var varCountry = document.getElementById("Country").value;
    var varPhone = document.getElementById("Phone").value;
    var varFax = document.getElementById("Fax").value;
    var longitudCompanyName = varCompanyName.length;



    if(varCompanyName=='' ||varContactName=='' ||varContactTitle=='' ||varAddress=='' ||varCity=='' ||varRegion=='' ||varPostalCode=='' ||varCountry=='' ||varPhone=='' ||varFax==''){
        alert("rellene Todos Los Campos");
    }
    else if (longitudCompanyName < 3) {
        alert("CompanyName debe de tener mínimo 3 caracteres");
    }
    else {
        alert("Correcto");
    }
    
}

function ValidaSoloNumeros() {
    if ((event.keyCode < 48) || (event.keyCode > 57))
        event.returnValue = false;
};
function formReset() {
    document.getElementById("xfor").reset();
};