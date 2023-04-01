$("#mgj8").click(function () {
    // pega as info do usuario
    var user = $("#user").val();
    var pass = $("#pass").val();

    // aqui vai o ajax carregando as informacoes (em json) para o back
    axios.post('http://localhost:8001/servertest', {
        user: user,
        pass: pass
    }).then(result => {
        console.log(result);
    });
});