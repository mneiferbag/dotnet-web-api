/*
 * Copyright (c) 2022 Markus Neifer
 * Licensed under the MIT License.
 * See file LICENSE in project root directory.
 */
namespace MnCons.Services.Tests
{
    using Xunit;
    using MnCons.Services;

    public class VerbService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var service = new VerbService();
            bool result = service.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}
