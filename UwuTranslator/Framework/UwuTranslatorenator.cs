using System.Collections.Generic;

namespace UwuTranslator.Framework
{
    public static class UwuTranslatorenator
    {
        //test string: Oh no, we made a mistake on the reports and now they don't work!
        private static Dictionary<string, string> wordReplacements = new Dictionary<string, string>()
        {
            { "little", "wittle" },
            { "Oh no", "Oopsie woopsie"},
            { "we made a mistake", "we made a wittle fucko boingo"},
            { "the", "da" }
        };
        private static Dictionary<string, string> letterReplacements = new Dictionary<string, string>
        {
            { "r", "w"}
        };
        
        public static string translate(string input)
        {
            var translation = input;
            //do a pass of words to entirely swap
            foreach (var w in wordReplacements.Keys)
            {
                translation = translation.Replace(w, wordReplacements[w]);
            }

            //do a pass to swap individual letters
            foreach (var l in letterReplacements.Keys)
            {
                translation = translation.Replace(l, letterReplacements[l]);
            }

            //return final string
            return translation;
        } 
    }
}