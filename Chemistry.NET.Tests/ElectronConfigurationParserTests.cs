/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Common;
using Chemistry.NET.Elements.Parsers.ElectronConfigurations;
using Xunit;

namespace Chemistry.NET.Tests.Models
{
    public class ElectronConfigurationParserTests
    {
        [Fact]
        public void Check_if_parsed_correctly()
        {
            var parser = new ElectronConfigurationParser();

            foreach (var element in Container.Elements)
            {
                var electronShellData = ElectronConfigurationParser.Parse(element.ElectronConfiguration);

                foreach (var data in electronShellData)
                {
                    Assert.NotNull(data.Shell);
                    Assert.NotEmpty(data.Subshells);
                }
            }
        }
    }
}
