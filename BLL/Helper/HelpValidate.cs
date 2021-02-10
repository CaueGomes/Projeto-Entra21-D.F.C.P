using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL.Helper
{
	public static class HelpValidate
	{
		public static string IsValidName(this string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				return "Nome deve ser informado.";
			}
			if (name.Length < 3 || name.Length > 50)
			{
				return "Nome deve ter entre 3 e 50 caracteres.";
			}
			return "";
		}
		public static string IsValidEmail(this string email)
		{
			Regex regex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");
			if (regex.IsMatch(email))
			{
				return "";
			}
			return "Email inválido";
		}
		public static string IsValidPasscode(this string passcode)
		{
			if (string.IsNullOrWhiteSpace(passcode))
			{
				return "Senha inválida.";
			}
			if (passcode.Length < 4 || passcode.Length > 10)
			{
				return "A senha deve conter entre 4 e 8 caracteres";
			}
			return "";
		}
		public static string EncryptPassword(this string passcode)
		{
			var encodedValue = Encoding.UTF8.GetBytes(passcode);
			var encryptedPassword = MD5.Create().ComputeHash(encodedValue);

			var sb = new StringBuilder();
			foreach (var caracter in encryptedPassword)
			{
				sb.Append(caracter.ToString("X2"));
			}
			return sb.ToString();
		}
	}

}
