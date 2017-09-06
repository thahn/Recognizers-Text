﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\English\English-Numbers.yaml
//     - Language: English
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.English
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = "Eng";
		public const string RoundNumberIntegerRegex = @"(hundred|thousand|million|billion|trillion)";
		public const string ZeroToNineIntegerRegex = @"(three|seven|eight|four|five|zero|nine|one|two|six)";
		public const string AnIntRegex = @"(an|a)(?=\s)";
		public const string TenToNineteenIntegerRegex = @"(seventeen|thirteen|fourteen|eighteen|nineteen|fifteen|sixteen|eleven|twelve|ten)";
		public const string TensNumberIntegerRegex = @"(seventy|twenty|thirty|eighty|ninety|forty|fifty|sixty)";
		public static readonly string SeparaIntRegex = $@"((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\s+{RoundNumberIntegerRegex})*))|(({AnIntRegex}(\s+{RoundNumberIntegerRegex})+))";
		public static readonly string AllIntRegex = $@"(((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(and\s+)?)*{SeparaIntRegex})";
		public const string PlaceHolderPureNumber = @"\b";
		public const string PlaceHolderDefault = @"\D|\b";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!(\.\d+[a-zA-Z]))(?={placeholder})";
		public const string NumbersWithSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s*(K|k|M|T|G)(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dozen(s)?(?=\b)";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((half\s+)?a\s+dozen)|({AllIntRegex}\s+dozen(s)?))(?=\b)";
		public const string RoundNumberOrdinalRegex = @"(hundredth|thousandth|millionth|billionth|trillionth)";
		public const string BasicOrdinalRegex = @"(first|second|third|fourth|fifth|sixth|seventh|eighth|ninth|tenth|eleventh|twelfth|thirteenth|fourteenth|fifteenth|sixteenth|seventeenth|eighteenth|nineteenth|twentieth|thirtieth|fortieth|fiftieth|sixtieth|seventieth|eightieth|ninetieth)";
		public static readonly string SuffixBasicOrdinalRegex = $@"((((({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(and\s+)?)*({TensNumberIntegerRegex}(\s+|\s*-\s*))?{BasicOrdinalRegex})";
		public static readonly string SuffixRoundNumberOrdinalRegex = $@"(({AllIntRegex}\s+){RoundNumberOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"({SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})";
		public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(1st|2nd|3rd|4th|5th|6th|7th|8th|9th|0th))|(11th|12th))(?=\b)";
		public const string OrdinalNumericRegex = @"(?<=\b)(\d{1,3}(\s*,\s*\d{3})*\s*th)(?=\b)";
		public static readonly string OrdinalRoundNumberRegex = $@"(?<!(a|an)\s+){RoundNumberOrdinalRegex}";
		public static readonly string OrdinalEnglishRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+(and\s+)?)?({AllIntRegex})(\s+|\s*-\s*)((({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))s|halves|quarters)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(and\s+)?)?(a|an|one)(\s+|\s*-\s*)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|half|quarter)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(({AllIntRegex})|((?<!\.)\d+))\s+over\s+(({AllIntRegex})|(\d+)(?!\.))(?=\b)";
		public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
		public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+point){AllPointRegex}";
		public const string DoubleWithMultiplierRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+\s*(K|k|M|G|T|B|b)(?=\b)";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))(\d+(\.\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))(\d+(\.\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+(?!(\.\d+))(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))\.\d+(?!(\.\d+))(?={placeholder})";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public const string CurrencyRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*(B|b|m|t|g)(?=\b)";
		public static readonly string NumberWithSuffixPercentage = $@"({BaseNumbers.NumberReplaceToken})(\s*)(%|per cents|per cent|cents|cent|percentage|percents|percent)";
		public static readonly string NumberWithPrefixPercentage = $@"(per cent of|percent of|percents of)(\s*)({BaseNumbers.NumberReplaceToken})";
		public const char DecimalSeparatorChar = '.';
		public const string FractionMarkerToken = "over";
		public const char NonDecimalSeparatorChar = ',';
		public const string HalfADozenText = "six";
		public const string WordSeparatorToken = "and";
		public static readonly string[] WrittenDecimalSeparatorTexts = { "point" };
		public static readonly string[] WrittenGroupSeparatorTexts = { "punto" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { "and" };
		public static readonly string[] WrittenFractionSeparatorTexts = { "and" };
		public const string HalfADozenRegex = @"half\s+a\s+dozen";
		public const string DigitalNumberRegex = @"((?<=\b)(hundred|thousand|million|billion|trillion|dozen(s)?)(?=\b))|((?<=(\d|\b))(k|t|m|g|b)(?=\b))";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ "a", 1 },
			{ "zero", 0 },
			{ "an", 1 },
			{ "one", 1 },
			{ "two", 2 },
			{ "three", 3 },
			{ "four", 4 },
			{ "five", 5 },
			{ "six", 6 },
			{ "seven", 7 },
			{ "eight", 8 },
			{ "nine", 9 },
			{ "ten", 10 },
			{ "eleven", 11 },
			{ "twelve", 12 },
			{ "dozen", 12 },
			{ "dozens", 12 },
			{ "thirteen", 13 },
			{ "fourteen", 14 },
			{ "fifteen", 15 },
			{ "sixteen", 16 },
			{ "seventeen", 17 },
			{ "eighteen", 18 },
			{ "nineteen", 19 },
			{ "twenty", 20 },
			{ "thirty", 30 },
			{ "forty", 40 },
			{ "fifty", 50 },
			{ "sixty", 60 },
			{ "seventy", 70 },
			{ "eighty", 80 },
			{ "ninety", 90 },
			{ "hundred", 100 },
			{ "thousand", 1000 },
			{ "million", 1000000 },
			{ "billion", 1000000000 },
			{ "trillion", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ "first", 1 },
			{ "second", 2 },
			{ "secondary", 2 },
			{ "half", 2 },
			{ "third", 3 },
			{ "fourth", 4 },
			{ "quarter", 4 },
			{ "fifth", 5 },
			{ "sixth", 6 },
			{ "seventh", 7 },
			{ "eighth", 8 },
			{ "ninth", 9 },
			{ "tenth", 10 },
			{ "eleventh", 11 },
			{ "twelfth", 12 },
			{ "thirteenth", 13 },
			{ "fourteenth", 14 },
			{ "fifteenth", 15 },
			{ "sixteenth", 16 },
			{ "seventeenth", 17 },
			{ "eighteenth", 18 },
			{ "nineteenth", 19 },
			{ "twentieth", 20 },
			{ "thirtieth", 30 },
			{ "fortieth", 40 },
			{ "fiftieth", 50 },
			{ "sixtieth", 60 },
			{ "seventieth", 70 },
			{ "eightieth", 80 },
			{ "ninetieth", 90 },
			{ "hundredth", 100 },
			{ "thousandth", 1000 },
			{ "millionth", 1000000 },
			{ "billionth", 1000000000 },
			{ "trillionth", 1000000000000 },
			{ "firsts", 1 },
			{ "halves", 2 },
			{ "thirds", 3 },
			{ "fourths", 4 },
			{ "quarters", 4 },
			{ "fifths", 5 },
			{ "sixths", 6 },
			{ "sevenths", 7 },
			{ "eighths", 8 },
			{ "ninths", 9 },
			{ "tenths", 10 },
			{ "elevenths", 11 },
			{ "twelfths", 12 },
			{ "thirteenths", 13 },
			{ "fourteenths", 14 },
			{ "fifteenths", 15 },
			{ "sixteenths", 16 },
			{ "seventeenths", 17 },
			{ "eighteenths", 18 },
			{ "nineteenths", 19 },
			{ "twentieths", 20 },
			{ "thirtieths", 30 },
			{ "fortieths", 40 },
			{ "fiftieths", 50 },
			{ "sixtieths", 60 },
			{ "seventieths", 70 },
			{ "eightieths", 80 },
			{ "ninetieths", 90 },
			{ "hundredths", 100 },
			{ "thousandths", 1000 },
			{ "millionths", 1000000 },
			{ "billionths", 1000000000 },
			{ "trillionths", 1000000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ "hundred", 100 },
			{ "thousand", 1000 },
			{ "million", 1000000 },
			{ "billion", 1000000000 },
			{ "trillion", 1000000000000 },
			{ "hundredth", 100 },
			{ "thousandth", 1000 },
			{ "millionth", 1000000 },
			{ "billionth", 1000000000 },
			{ "trillionth", 1000000000000 },
			{ "hundredths", 100 },
			{ "thousandths", 1000 },
			{ "millionths", 1000000 },
			{ "billionths", 1000000000 },
			{ "trillionths", 1000000000000 },
			{ "dozen", 12 },
			{ "dozens", 12 },
			{ "k", 1000 },
			{ "m", 1000000 },
			{ "g", 1000000000 },
			{ "b", 1000000000 },
			{ "t", 1000000000000 }
		};
	}
}