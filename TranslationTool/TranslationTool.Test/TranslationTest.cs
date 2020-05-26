using System;
using Translation.WebApi.GooleApi.BrokenTranslation;
using Xunit;

namespace TranslationTool.Test
{
    public class TranslationTest
    {
        [Fact]
        public async void GoogleTranslationTest()
        {
            var translation = await GooleBrokenTranslationService.GetTranslationAsync("apple");
            Console.WriteLine(translation);
        }
    }
}
