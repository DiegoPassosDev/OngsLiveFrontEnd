$(document).ready(function () {
    $('#cep').blur(function () {
        var cep = $(this).val().replace(/\D/g, '');
        if (cep.length != 8) {
            return false;
        }
        var url = 'https://viacep.com.br/ws/' + cep + '/json/';
        $.getJSON(url, function (data) {
            if ('error' in data) {
                alert('CEP não encontrado.');
                return false;
            }
            $('#logradouro').val(data.logradouro);
            $('#bairro').val(data.bairro);
            $('#cidade').val(data.localidade);
            $('#estado').val(data.uf);
        });
    })
});

function formatCPF(cpf) {
    cpf = cpf.replace(/\D/g, '');
    cpf = cpf.replace(/(\d{3})(\d)/, '$1.$2');
    cpf = cpf.replace(/(\d{3})(\d)/, '$1.$2');
    cpf = cpf.replace(/(\d{3})(\d{1,2})$/, '$1-$2');
    return cpf;
}

//Validação do E-mail
const emailInput = document.getElementById('email');
const emailValidation = document.getElementById('email-validation');
const form = document.querySelector('form');
const btnsend = $('#btn');
function validateEmail() {
    const email = emailInput.value.trim();
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (!emailRegex.test(email)) {
        emailValidation.classList.remove('valid');
        emailValidation.classList.add('invalid');
        return false;
    }

    emailValidation.classList.remove('invalid');
    emailValidation.classList.add('valid');
    return true;
}

function validateForm(event) {
    const isEmailValid = validateEmail();

    if (!isEmailValid) {
        emailInput.focus();
        event.preventDefault();
    }
}

emailInput.addEventListener('input', validateEmail);
form.addEventListener('submit', validateForm);

//Validando a DATA DE NASCIMENTO
$(document).ready(function () {
    $('#nascimento').mask('99/99/9999');
});

function validarDataNascimento() {
    var dataNascimento = $('#data-nascimento').val().replace(/_/g, '');

    if (dataNascimento.length != 10) {
        alert('Data de nascimento inválida');
        $('#data-nascimento').focus();
        return false;
    }

    var dia = parseInt(dataNascimento.substring(0, 2));
    var mes = parseInt(dataNascimento.substring(3, 5));
    var ano = parseInt(dataNascimento.substring(6, 10));

    if (isNaN(dia) || isNaN(mes) || isNaN(ano)) {
        alert('Data de nascimento inválida');
        $('#data-nascimento').focus();
        return false;
    }

    var data = new Date(ano, mes - 1, dia);

    if (data.getFullYear() != ano || data.getMonth() != mes - 1 || data.getDate() != dia) {
        alert('Data de nascimento inválida');
        $('#data-nascimento').focus();
        return false;
    }

    return true;
}

var id = 0;
$('#btn').click(function () {
    id = id + 1;
    var listData = new Object();
    listData = {
        id: id,
        nome: $('#nome').val(),
        sobrenome: $('#sobrenome').val(),
        dataNascimento: $('#nascimento').val(),
        email: $('#email').val(),
        telefone: $('#telefone').val(),
        cpf: $('#cpf').val(),
        genero: $('#genero').val(),
        cep: $('#cep').val(),
        bairro: $('#bairro').val(),
        estado: $('#estado').val(),
        cidade: $('#cidade').val(),
        enderecoLinhaUm: $('#logradouro').val(),
        numero: $('#numero').val(),
    }
    console.log(listData);

    // Resivar data de nascimento; as id's nao podem ficar nulas e nem o numero do endereco
    axios.post("https://192.168.100.21:7185/api/Voluntarios", {
        id: id,
        nome: $('#nome').val(),
        sobrenome: $('#sobrenome').val(),
        dataNascimento: $('#nascimento').val(),
        email: $('#email').val(),
        telefone: $('#telefone').val(),
        cpf: $('#cpf').val(),
        genero: $('#genero').val(),
        endereco: {
            id: id,
            cep: $('#cep').val(),
            bairro: $('#bairro').val(),
            estado: $('#estado').val(),
            cidade: $('#cidade').val(),
            enderecoLinhaUm: $('#logradouro').val(),
            numero: parseInt($('#numero').val())
        }
    }).then(result => {
        console.log(result);
    });
});