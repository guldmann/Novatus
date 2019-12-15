using System;
using System.IO;
using Xunit;
using NovatusCommon;
using FluentAssertions;

namespace NovatusCommonTest
{
    public class Sha256HAsh
    {
        [Fact]
        public void When_Hash_is_created_right_value_is_returnd()
        {
            //Arrange
            var testString = "This is a test string";
            var expected = "717AC506950DA0CCB6404CDD5E7591F72018A20CBCA27C8A423E9C9E5626AC61";

            //Act 
            var result = testString.GetHashString();

            //Assert 
            result.Should().Be(expected);
        }

        [Fact]
        public void When_file_is_hashed_no_error_is_thrown_and_correct_hash_is_returned()
        {
            //Arrange 
            var expectedString = "3EC32196F7277C895B6C8E9FF51FF9FF820F0399EC6804524780B142507C8D7B";

            //Act
            var result = SHA256Hash.GetHashFromFile("TestFiles/file.exe");

            //Assert
            result.Should().Be(expectedString);
        }

        [Fact]
        public void When_file_dont_exist_FileNotFoundException_is_thrown()
        {
            //Assert
            Assert.Throws<FileNotFoundException>(() => SHA256Hash.GetHashFromFile("TestFiles/file.exeertert"));
        }
    }
}
