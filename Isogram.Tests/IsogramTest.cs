using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class IsogramTest
    {
        [Fact]
        public void ShouldHoldTrueForEmptyString()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("");
            var expected = true;

            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldTrueForWordIsogramWithLowerCaseCharacters()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("isogram");
            var expected = true;
            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldFalseForWordEleven()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("eleven");
            var expected = false;
            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldTrueForLongReportedEnglishWordLikeSubdermatoglyphic()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("subdermatoglyphic");
            var expected = true;
            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldTrueForWordWithDuplicatedCharacterInMixedCaseAlphabet()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("Alphabet");
            var expected = true;
            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldTrueForWordWithHyphenThumbscrewJapingly()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("thumbscrew-japingly");
            var expected = true;
            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldTrueForWordWithDuplicatedFHyphenSixyearold()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("six-year-old");
            var expected = true;
            Assert.True(expected == actual);
        }

        [Fact]
        public void ShouldHoldTrueForNameWhichIsSeperatedBySpaces()
        {
            Isogram i = new Isogram();

            var actual = i.IsIsogram("Ros Eckler");
            var expected = true;
            Assert.True(expected == actual);
        }
    }
}
