using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AdzuInfluencerMarketing.Localization
{
    public static class AdzuInfluencerMarketingLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AdzuInfluencerMarketingConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AdzuInfluencerMarketingLocalizationConfigurer).GetAssembly(),
                        "AdzuInfluencerMarketing.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
