﻿//using System.IO;
//using System.Threading.Tasks;
//using Xabe.FFmpeg.Enums;
//using Xunit;
//
//namespace Xabe.FFmpeg.Test
//{
//    public class SubtitleTests
//    {
//        [Theory]
//        [InlineData(SubtitleFormat.ASS)]
//        [InlineData(SubtitleFormat.WebVTT)]
//        [InlineData(SubtitleFormat.SRT)]
//        public async Task ConvertTest(SubtitleFormat subtitleFormat)
//        {
//            string outputPath = Path.ChangeExtension(Path.GetTempFileName(), "");
//            bool conversionResult = await new Subtitle(Resources.SubtitleSrt).Convert(outputPath, subtitleFormat);
//
//            Assert.True(conversionResult);
//        }
//    }
//}
