// Copyright(c) 2017 Takahiro Miyaura
// Released under the MIT license
// http://opensource.org/licenses/mit-license.php

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