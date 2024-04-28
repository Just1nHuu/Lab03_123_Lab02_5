using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lab03_4
{
        class cPhim
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("GiaVeChuan")]
            public int GiaVe { get; set; }
            [JsonPropertyName("PhongChieu")]
            public int[]? PhongChieu { get; set; }
        }
        class cDanhGiaPhim
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("SoLuongBanVe")]
            public int SoLuongBanVe { get; set; }
            [JsonPropertyName("SoLuongTonVe")]
            public int SoLuongTonVe { get; set; }
            [JsonPropertyName("TiLeBanVe")]
            public double TiLeBanRa { get; set; }
            [JsonPropertyName("DoanhThu")]
            public int DoanhThu { get; set; }
            [JsonPropertyName("XepHangDoanhThu")]
            public int XepHangDoanhThu { get; internal set; }
        }
        class ViTriGheDat
        {
            public string Ten { get; set; }
            public int Phong { get; set; }
            public string HangGhe { get; set; }
            public int SoGhe { get; set; }
        }
}
