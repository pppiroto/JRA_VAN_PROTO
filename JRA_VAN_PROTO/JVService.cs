using System;
using System.Collections.Generic;
using System.Text;

namespace JRA_VAN_PROTO
{
    public class JVService
    {
     

        /// <summary>
        /// JVOpenで指定可能なオプションを取得する
        /// Tagは指定可能あdataspec
        /// </summary>
        /// <returns></returns>
        public static List<Parameter> GetJVOpenOptions()
        {
            return new List<Parameter> {
                new Parameter(){TypeName="option", Code="1", Name="通常データ", Explain="", Tag="TOKU,RACE,DIFF,BLOD,SNAP,SLOP,YSCH,HOSE,HOYU,COMM,MING" },
                new Parameter(){TypeName="option", Code="2", Name="今週データ", Explain="", Tag="TOKU,RACE,TCOV,RCOV,SNAP" },
                new Parameter(){TypeName="option", Code="3", Name="セットアップデータ", Explain="", Tag="TOKU,RACE,DIFF,BLOD,SNAP,SLOP,YSCH,HOSE,HOYU,COMM,MING" },
                new Parameter(){TypeName="option", Code="4", Name="セットアップデータ", Explain="",  Tag="TOKU,RACE,DIFF,BLOD,SNAP,SLOP,YSCH,HOSE,HOYU,COMM,MING" },
            };
        }
        /// <summary>
        /// データ種別
        /// </summary>
        /// <returns></returns>
        public static List<Parameter> GetDataSpec()
        {
            return new List<Parameter> {
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="TOKU", Name="特別登録馬情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="RACE", Name="レース情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="DIFF", Name="蓄積系ソフト用　蓄積情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="BLOD", Name="蓄積系ソフト用　血統情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="MING", Name="蓄積系ソフト用　マイニング情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="SNAP", Name="出走時点情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="SLOP", Name="坂路調教情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="YSCH", Name=" 開催スケジュール", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="HOSE", Name="競走馬市場取引価格", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="HOYU", Name="馬名の意味由来情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="COMM", Name="各種解説情報", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="TCOV", Name="非蓄積系ソフト用　特別登録馬情報補填", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="蓄積系", Code="RCOV", Name="非蓄積系ソフト用　レース情報補補填", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B12", Name="速報レース情報(成績確定後）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B15", Name="速報レース情報(出走馬名表～） ", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B30", Name="速報オッズ(全賭式) ", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B31", Name="速報オッズ（単複枠）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B32", Name="速報オッズ（馬連）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B33", Name="速報オッズ（ワイド）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B34", Name="速報オッズ（馬単）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B35", Name="速報オッズ（３連複）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B36", Name="速報オッズ（３連単）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B20", Name="速報票数(全賭式)", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B11", Name="速報馬体重", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B14", Name="速報開催情報(一括)", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B16", Name="速報開催情報(指定)", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B13", Name="速報タイム型データマイニング予想", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B17", Name="速報対戦型データマイニング予想", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B41", Name="時系列オッズ（単複枠）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B42", Name="時系列オッズ（馬連）", Explain="", Tag="" },
                new Parameter(){TypeName="dataSpec", LabelType=2, Category="速報系", Code="0B51", Name="速報重勝式(WIN5)", Explain="", Tag="" },
            };
        }

    }


    public class Parameter
    {
        public string TypeName {get; set;}
        public string Code { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }

        public string Explain { get; set; }

        public string Category { get; set; }

        public int LabelType { get; set; }

        public int CodeAsInt
        {
            get
            {
                return int.Parse(Code);
            }
        }

        public override string ToString()
        {
            if (LabelType == 2)
            {
                return $"{Category}({Code}){Name}";
            } 
            return $"{Code}:{Name}";
        }
    }
}
