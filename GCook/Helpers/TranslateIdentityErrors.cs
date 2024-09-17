using System.Security.Cryptography;

namespace GCook.Helpers;

public static class TranslateIdentityErrors
{
    public static string TranslateErrorMessage(string codeError)
    {
        string message = codeError switch
        {
            "DefaultError" => "Ocorreu um erro desconhecido.",
            "ConcurrencyFailure" => "Falha de concorrência otimista, o objeto foi modificado.",
            "InvalidToken" => "Token inválido.",
            "LoginAlreadyAssociated" => "Já existe um usuário com este login.",
            "InvalidUserName" => $"Este login é inválido, um login deve conter apenas letras ou dígitos.",
            "InvalidEmail" => "E-mail inválido.",
            "DuplicateUserName" => "Este login já está sendo usado.",
            "DuplicateEmail" => $"Este email já está sendo usado.",
            "InvalidRoleName" => "Esta Permissão é inválida.",
            "DuplicateRoleName" => "Esta permissão já está sendo usada.",
            "UserAlreadyInRole" => "Usuário já possui essa permissão.",
            "UserNotInRole" => "Usuário não tem essa permissão.",
            "UserLockoutNotEnableb" => "Lockout não está habilitado para esse usuário.",
            "UserAlreadyHasPassoword" => "Usuário já possui uma senha definida.",
            "PasswordMismatch" => "Senha Incorreta.",
            "PasswordTooShort" => "Senha muito curta.",
            "PasswordRequiresNonAlphanumeric" => "Senhas devem conter ao menos um caracter não alfanúmerico.",
            "PasswordRequiresDigit" => "Senhas devem conter ao menos um digito ('0'- '9').",
            "PasswordRequiresLower" => "Senhas devem conter ao menos um caracter em caixa baixa ('a'-'z').",
            "PasswordRequiresUpper" => "Senhas devem conter ao menos um caracter em caixa alta ('A' - 'Z').",
            _ => "Ocorreu um erro desconhecido.",
        };
        return message;
    }
}