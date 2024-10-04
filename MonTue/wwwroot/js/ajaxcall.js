$(document).ready(function () {
    $("#employeeForm").submit(function (event) {
        event.preventDefault(); // Prevent default form submission

        $.ajax({
            url: '/Employee/AddEmployee', // Form action URL
            type: 'POST', // HTTP method
            data: $(this).serialize(), // Serialize form data
            success: function (response) {
                // JavaScript to prepend the success message
                $('.card-body').prepend('<div class="success-message">Employee Added Successfully</div>');

                // Automatically fade out the success message after 3 seconds
                setTimeout(function () {
                    $('.success-message').fadeOut('slow');
                }, 1500);

                console.log(response);

                $.ajax({
                    url: '/Employee/GetEmployee',
                    type: 'GET',
                    success: function (data) {

                        $("#EmployeeListContainer").html(data);
                        //console.log(data)
                    }
                });
            },

            error: function (xhr, status, error) {
                // Handle errors, e.g., show an error message
            }
        });
    });
   


});