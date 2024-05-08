using Microsoft.AspNetCore.Identity;

namespace EasyCash_proje_Edenyity.PresentationLayer.Models
{
	public class CustomerIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PassWordTooShort",
				Description = $"Şifrə en azı {length} xarakter olmalidi"
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Zəhmət olmasa en azı bir boyük hərf daxil edin"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Zəhmət olmasa en azı bir kiçik hərf daxil edin"
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "Zəhmət olmasa en azı bir reqəm daxil edin"
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Zəhmət olmasa en azı bir simvol daxil edin"
			};
		}
		
	}

}
