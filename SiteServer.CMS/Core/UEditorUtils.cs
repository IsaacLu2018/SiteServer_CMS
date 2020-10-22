using System.Collections.Generic;
using SiteServer.CMS.Model;
using SiteServer.CMS.StlParser.StlElement;
using SiteServer.Utils;

namespace SiteServer.CMS.Core
{
    public static class UEditorUtils
    {
        public const string ConfigValues = "{allowDivTransToP: false, maximumWords:99999999}";

        public static string GetInsertHtmlScript(string attributeName, string html)
        {
            html = html.Replace("\"", "'");
            string script = $@"UE.getEditor(""{attributeName}"", {ConfigValues}).execCommand(""insertHTML"",""{html}"");";
            if (!string.IsNullOrEmpty(html))
            {
                html = html.Replace(@"""", @"\""");
                script = $@"UE.getEditor(""{attributeName}"", {ConfigValues}).execCommand(""insertHTML"",""{html}"");";
            }
            return script;
        }

        public static string GetEditorInstanceScript()
        {
            return "UE";
        }

        public static string GetInsertVideoScript(string attributeName, string playUrl, string imageUrl, SiteInfo siteInfo)
        {
            if (string.IsNullOrEmpty(playUrl)) return string.Empty;

            //{ StlPlayer.PlayUrl, playUrl},
            //    { StlPlayer.IsAutoPlay, siteInfo.Additional.ConfigUEditorVideoIsAutoPlay.ToString()},
            //    { StlPlayer.PlayBy, siteInfo.Additional.ConfigUEditorVideoPlayBy},

            var dict = new Dictionary<string, string>
            {
                {HTMLModel.Video.src,playUrl },
                { HTMLModel.Video.autoplay, siteInfo.Additional.ConfigUEditorVideoIsAutoPlay.ToString()},
                { HTMLModel.Video.controls,"controls"}
            };
            if (siteInfo.Additional.ConfigUEditorVideoIsImageUrl && !string.IsNullOrEmpty(imageUrl))
            {
                dict.Add(HTMLModel.Video.poster, imageUrl);
            }
            if (siteInfo.Additional.ConfigUEditorVideoIsWidth)
            {
                dict.Add(HTMLModel.Video.width, siteInfo.Additional.ConfigUEditorVideoWidth.ToString());
            }
            if (siteInfo.Additional.ConfigUEditorVideoIsHeight)
            {
                dict.Add(HTMLModel.Video.height, siteInfo.Additional.ConfigUEditorVideoHeight.ToString());
            }

            return GetInsertHtmlScript(attributeName,
                $@"<video {StlPlayer.EditorPlaceHolder} {TranslateUtils.ToAttributesString(dict)} />");
        }

        public static string GetInsertAudioScript(string attributeName, string playUrl, SiteInfo siteInfo)
        {
            if (string.IsNullOrEmpty(playUrl)) return string.Empty;

            //{ StlAudio.PlayUrl, playUrl},
            //    { StlAudio.IsAutoPlay, siteInfo.Additional.ConfigUEditorAudioIsAutoPlay.ToString()},
            var dict = new Dictionary<string, string>
            {
                {HTMLModel.Audio.src,playUrl },
                { HTMLModel.Audio.autoplay, siteInfo.Additional.ConfigUEditorVideoIsAutoPlay.ToString()},
                { HTMLModel.Video.controls,"controls"}
            };


            //GetInsertHtmlScript(attributeName,
            //    $@"<img {StlAudio.EditorPlaceHolder} {TranslateUtils.ToAttributesString(dict)} />")
            return GetInsertHtmlScript(attributeName,
                $@"<audio {StlAudio.EditorPlaceHolder} {TranslateUtils.ToAttributesString(dict)} />");
        }

        public static string GetPureTextScript(string attributeName)
        {
            string script = $@"UE.getEditor(""{attributeName}"", {ConfigValues}).getContentTxt();";
            return script;
        }

        public static string GetContentScript(string attributeName)
        {
            string script = $@"UE.getEditor(""{attributeName}"", {ConfigValues}).getContent();";
            return script;
        }

        public static string GetSetContentScript(string attributeName, string contentWithoutQuote)
        {
            string script = $@"UE.getEditor(""{attributeName}"", {ConfigValues}).setContent({contentWithoutQuote});";
            return script;
        }

        public static string TranslateToStlElement(string html)
        {
            var retVal = html;
            if (!string.IsNullOrEmpty(retVal))
            {
                retVal = retVal.Replace($"<img {StlPlayer.EditorPlaceHolder} ", $"<{StlPlayer.ElementName} ");
                retVal = retVal.Replace($"<img {StlAudio.EditorPlaceHolder} ", $"<{StlAudio.ElementName} ");
                retVal = retVal.Replace($"<img {StlLibrary.EditorPlaceHolder} ", $"<{StlLibrary.ElementName} ");
            }
            return retVal;
        }

        public static string TranslateToHtml(string html)
        {
            var retVal = html;
            if (!string.IsNullOrEmpty(retVal))
            {
                retVal = retVal.Replace($"<{StlPlayer.ElementName} ", $"<img {StlPlayer.EditorPlaceHolder} ");
                retVal = retVal.Replace($"<{StlAudio.ElementName} ", $"<img {StlAudio.EditorPlaceHolder} ");
                retVal = retVal.Replace($"<{StlLibrary.ElementName} ", $"<img {StlLibrary.EditorPlaceHolder} ");
            }
            return retVal;
        }
    }
}
