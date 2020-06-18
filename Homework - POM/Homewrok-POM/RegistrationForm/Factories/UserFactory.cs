using AutoFixture;
using SelenuimAdvHomework.RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelenuimAdvHomework.RegistrationForm
{
    public static class UserFactory
    {
        public static RegistrationFormModel CreateValidUser()
        {
            var fixture = new Fixture();
            var dateTime = fixture.Create<DateTime>();

            return new RegistrationFormModel
            {

                createAccountEmailAdressField = fixture.Create<string>(),
                firstNameInCreateAccount = "First Name",
                lastNameInCreateAccount = "Last Name",
                passwordInCreateAccount = "Password",
                addressInCreateAccount = fixture.Create<string>(),
                cityInCreateAccount = fixture.Create<string>(),
                postalCodeInCreateAccount = "90000",
                phoneNumberInCreateForm = "0896951793",
                stateInCreateAccount = "Alabama",
                countryInCreateAccount = "United States",
                assignAddressInCreateForm = "Home",
            };
        }

    }
}
