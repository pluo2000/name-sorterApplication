﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using name_sorter.Library.Helpers;
using name_sorter.Library.Models;
using Xunit;

namespace name_sorter.Library.Tests
{
    public class NamesStringConverterTest
    {

        [Fact]
        public void StringToNamesConversion_ShouldWork()
        {
            //
            //sample names in string
            //
            string nameInString = "John Smith" + "|" + "Jake Jackson Lee"+"|" + "Rob Smyth" + "|" + "Angela Nash" + "|";

            //
            //expected list of name object
            //
            Name name1 = new Name("John", "Smith");
            Name name2 = new Name("Jake Jackson", "Lee");
            Name name3 = new Name("Rob", "Smyth");
            Name name4 = new Name("Angela", "Nash");

            List<Name> expected = new List<Name>();
            expected.Add(name1);
            expected.Add(name2);
            expected.Add(name3);
            expected.Add(name4);

            //
            //actual names in string 
            //
            List<Name> actual = NamesStringConverter.ConvertStringToNames(nameInString);

            //
            //Assert
            //
            Assert.Equal(expected[0].FirstName,actual[0].FirstName);
            Assert.Equal(expected[0].LastName, actual[0].LastName);

            Assert.Equal(expected[1].FirstName, actual[1].FirstName);
            Assert.Equal(expected[1].LastName, actual[1].LastName);

            Assert.Equal(expected[2].FirstName, actual[2].FirstName);
            Assert.Equal(expected[2].LastName, actual[2].LastName);

            Assert.Equal(expected[3].FirstName, actual[3].FirstName);
            Assert.Equal(expected[3].LastName, actual[3].LastName);
        }
    }
}