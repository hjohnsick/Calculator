using Xunit;
using Practice;
using Practice.Models;
using System.Collections.Generic;
using System;

namespace Practice.Tests
{
    public class DataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(newPerson, people);
        }

        
        [Theory]
        [InlineData("Tim", "", "LastName")]
        [InlineData("", "Crocker", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }

       [Fact]
        public void ConvertModelsToCSV_ShouldPass()
        {
            
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel() { FirstName = "Heather", LastName = "Johnsick" },
                new PersonModel() { FirstName = "Ben", LastName = "Burton"}
            };

            List<string> expected = new List<string> { "Heather, Johnsick", "Ben, Burton" };
            var result = DataAccess.ConvertModelsToCSV(people);
            Assert.NotEmpty(result);

            Assert.Equal(expected, result);
            
        }

        [Fact]
        public void SplitingData_ShouldSplitData()
        {
            List<PersonModel> output = new List<PersonModel>();
            string[] content = { "Heather, Johnsick", "Ben, Burton" };

            DataAccess.SplitingData(output, content);

            Assert.All(output, item => DataAccess.SplitingData(output, content));
        }
    }
}
