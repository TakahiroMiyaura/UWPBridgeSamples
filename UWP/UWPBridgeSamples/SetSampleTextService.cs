// Copyright(c) 2017 Takahiro Miyaura

namespace UWPBridgeSamples
{
    public class SetSampleTextService : SetSampleText.ISetSampleTextService
    {
        public string GetText()
        {
            return "Sample Text For UWP";
        }
    }
}