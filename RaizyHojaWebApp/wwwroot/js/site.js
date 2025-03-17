$(document).ready(function () {

    // Envío del formulario de contacto con AJAX y SweetAlert2 
   
    $("#contactForm").submit(function (e) {
        e.preventDefault();

        $.ajax({
            url: $(this).attr("action"),
            type: "POST",
            data: $(this).serialize(),
            success: function () {
                Swal.fire({
                    title: "¡Mensaje enviado!",
                    text: "Nos pondremos en contacto pronto.",
                    icon: "success",
                    confirmButtonText: "Aceptar"
                }).then(() => {
                    $("#contactModal").modal("hide"); // Cierra el modal
                    $("#contactForm")[0].reset(); // Resetea el formulario
                });
            },
            error: function () {
                Swal.fire({
                    title: "Error",
                    text: "Hubo un problema al enviar el formulario. Inténtalo nuevamente.",
                    icon: "error",
                    confirmButtonText: "Aceptar"
                });
            }
        });
    });


    
    //Scroll suave al hacer clic en los enlaces del header
    $("a[href^='#']").click(function (e) {
        e.preventDefault();

        let target = $(this.hash); // Obtiene la sección a la que debe hacer scroll
        if (target.length) {
            $("html, body").animate({
                scrollTop: target.offset().top - 80
            }, 800); 
        }
    });

});

// animacion de formulario modal
document.addEventListener('DOMContentLoaded', function () {
    const contactModal = document.getElementById('contactModal');

    contactModal.addEventListener('show.bs.modal', function (event) {
        // inicia la animacion desde abajo del botncito
        setTimeout(() => {
            document.querySelector('.modal-dialog-bottom-right').classList.add('show');
        }, 50);
    });

    contactModal.addEventListener('hide.bs.modal', function (event) {
        // vuelve a ocultar el modal para la proxima
        document.querySelector('.modal-dialog-bottom-right').classList.remove('show');
    });
});