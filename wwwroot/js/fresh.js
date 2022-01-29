
    $(document).ready(function () {  
      getCustomerList();  
    });  
  
    var Customer = {  
      id: 0,  
      firstname: "",
      lastname: "", 
      email: "", 
      phone: "",
      address: "",
      username: "",
      gender: ""  
       
    }  
  
    // Get all Employees to display  
    function getCustomerList() {  
      // Call Web API to get a list of Employees  
      $.ajax({  
        url: '/api/GetCustomers/',  
        type: 'GET',  
        dataType: 'json',  
        success: function (customers) {  
          employeeListSuccess(customers);  
        },  
        error: function (request, message, error) {  
          handleException(request, message, error);  
        }  
      });  
    }  
  
    // Display all Employees returned from Web API call  
    function customerListSuccess(customers) {  
      // Iterate over the collection of data  
      $("#customerTable tbody").remove();  
      $.each(customers, function (index, customer) {  
        // Add a row to the employee table  
        customerAddRow(customer);  
      });  
    }  
  
    // Add employee row to <table>  
    function customerAddRow(customer) {  
      // First check if a <tbody> tag exists, add one if not  
      if ($("#customerTable tbody").length == 0) {  
        $("#customerTable").append("<tbody></tbody>");  
      }  
  
      // Append row to <table>  
      $("#customerTable tbody").append(  
        employeeBuildTableRow(customer));  
    }  
  
    // Build a <tr> for a row of table data  
    function customerBuildTableRow(customer) {  
      var newRow = "<tr>" +  
        "<td>" + customer.id + "</td>" +  
        "<td><input   class='input-firstname' type='text' value='" + customer.firstname + "'/></td>" +  
        "<td><input   class='input-lastname' type='text' value='" + customer.lastname + "'/></td>" + 
        "<td><input   class='input-email' type='text' value='" + customer.email + "'/></td>" + 
        "<td><input   class='input-phone' type='text' value='" + customer.phone + "'/></td>" + 
        "<td><input   class='input-address' type='text' value='" + customer.address + "'/></td>" + 
        "<td><input   class='input-username' type='text' value='" + customer.username + "'/></td>" + 
        "<td><input  class='input-gender'  type='text' value='" + customer.gender + "'/></td>" +  
         
        "<td>" +  
        "<button type='button' " +  
        "onclick='customeUpdate(this);' " +  
        "class='btn btn-default' " +  
        "data-id='" + customer.id + "' " +  
        "data-firstname='" + customer.firstname + "' " +  
        "data-lastname='" + customer.lastname + "' " + 
        "data-email='" + customer.email + "' " + 
        "data-phone='" + customer.phone + "' " + 
        "data-address='" + customer.address + "' " + 
        "data-username='" + customer.username + "' " + 
        "data-gender='" + customer.gender + "' " +  
         
        ">" +  
        "<span class='glyphicon glyphicon-edit' /> Update" +  
        "</button> " +  
        " <button type='button' " +  
        "onclick='employeeDelete(this);'" +  
        "class='btn btn-default' " +  
        "data-id='" + employee.id + "'>" +  
        "<span class='glyphicon glyphicon-remove' />Delete" +  
        "</button>" +  
        "</td>" +  
        "</tr>";  
  
      return newRow;  
    }  
  
    function onAddCustomer(item) {  
      var options = {};  
      options.url = "/api/AddCustomer";  
      options.type = "POST";  
      var customer = Customer;  
      customer.firstname = $("#firstname").val();  
      customer.lastname = $("#lastname").val(); 
      customer.email = $("#email").val(); 
      customer.phone = $("#phone").val();  
      customer.address = $("#address").val(); 
      customer.username = $("#username").val();  
      console.dir(customer);  
      options.data = JSON.stringify(customer);  
      options.contentType = "application/json";  
      options.dataType = "html";  
  
      options.success = function (msg) {  
        getCustomerList();  
        $("#msg").html(msg);  
      },  
        options.error = function () {  
          $("#msg").html("Error while calling the Web API!");  
        };  
      $.ajax(options);  
    }  
  
    function customerUpdate(item) {  
      var id = $(item).data("id");  
      var options = {};  
      options.url = "/api/UpdateCustomer/"  
      options.type = "PUT";  
  
      var customer = Customer;  
      customer.id = $(item).data("id");  
      customer.firstname = $(".input-firstname", $(item).parent().parent()).val();  
      customer.lastname = $(".input-lastname", $(item).parent().parent()).val();  
      customer.email = $(".input-email", $(item).parent().parent()).val();  
      customer.phone = $(".input-phone", $(item).parent().parent()).val(); 
      customer.address = $(".input-address", $(item).parent().parent()).val(); 
      customer.username = $(".input-username", $(item).parent().parent()).val();    
      customer.gender = $(".input-gender", $(item).parent().parent()).val();    
      console.dir(customer);  
      options.data = JSON.stringify(customer);  
      options.contentType = "application/json";  
      options.dataType = "html";  
      options.success = function (msg) {  
        $("#msg").html(msg);  
      };  
      options.error = function () {  
        $("#msg").html("Error while calling the Web API!");  
      };  
      $.ajax(options);  
    }  
  
    function customerDelete(item) {  
      var id = $(item).data("id");  
      var options = {};  
      options.url = "/api/DeleteCustomer/"  
        + id;  
      options.type = "DELETE";  
      options.dataType = "html";  
      options.success = function (msg) {  
        console.log('msg= ' + msg);  
        $("#msg").html(msg);  
        getCustomerList();  
      };  
      options.error = function () {  
        $("#msg").html("Error while calling the Web API!");  
      };  
      $.ajax(options);  
    }  
  
    // Handle exceptions from AJAX calls  
    function handleException(request, message, error) {  
      var msg = "";  
      msg += "Code: " + request.status + "\n";  
      msg += "Text: " + request.statusText + "\n";  
      if (request.responseJSON != null) {  
        msg += "Message" + request.responseJSON.Message + "\n";  
      }  
  
      alert(msg);  
    }  
   