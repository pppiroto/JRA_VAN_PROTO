using System;
using System.Collections.Generic;
using System.Text;
using static JRA_VAN_PROTO.JVData_Struct;

namespace JRA_VAN_PROTO.Handler
{
    public class KeyBodyFileWirteHandler : FileWriteHander
    {
        public static readonly string SEP = "\t";

        JV_TK_TOKUUMA tk          = new JV_TK_TOKUUMA();
        JV_RA_RACE ra             = new JV_RA_RACE();
        JV_SE_RACE_UMA se         = new JV_SE_RACE_UMA();
        JV_HR_PAY hr              = new JV_HR_PAY();
        JV_H1_HYOSU_ZENKAKE h1    = new JV_H1_HYOSU_ZENKAKE();
        JV_H6_HYOSU_SANRENTAN h6  = new JV_H6_HYOSU_SANRENTAN();
        JV_O1_ODDS_TANFUKUWAKU o1 = new JV_O1_ODDS_TANFUKUWAKU();
        JV_O2_ODDS_UMAREN o2      = new JV_O2_ODDS_UMAREN();
        JV_O3_ODDS_WIDE o3        = new JV_O3_ODDS_WIDE();
        JV_O4_ODDS_UMATAN o4      = new JV_O4_ODDS_UMATAN();
        JV_O5_ODDS_SANREN o5      = new JV_O5_ODDS_SANREN();
        JV_O6_ODDS_SANRENTAN o6   = new JV_O6_ODDS_SANRENTAN();
        JV_UM_UMA um              = new JV_UM_UMA();
        JV_KS_KISYU ks            = new JV_KS_KISYU();
        JV_CH_CHOKYOSI ch         = new JV_CH_CHOKYOSI();
        JV_BR_BREEDER br          = new JV_BR_BREEDER();
        JV_BN_BANUSI bn           = new JV_BN_BANUSI();
        JV_HN_HANSYOKU hn         = new JV_HN_HANSYOKU();
        JV_SK_SANKU sk            = new JV_SK_SANKU();
        JV_CK_CHAKU ck            = new JV_CK_CHAKU();
        JV_RC_RECORD rc           = new JV_RC_RECORD();
        JV_HC_HANRO hc            = new JV_HC_HANRO();
        JV_HS_SALE hs             = new JV_HS_SALE();
        JV_HY_BAMEIORIGIN hy      = new JV_HY_BAMEIORIGIN();
        JV_YS_SCHEDULE ys         = new JV_YS_SCHEDULE();
        JV_BT_KEITO bt            = new JV_BT_KEITO();
        JV_CS_COURSE cs           = new JV_CS_COURSE();
        JV_DM_INFO dm             = new JV_DM_INFO();
        JV_TM_INFO tm             = new JV_TM_INFO();
        JV_WF_INFO wf             = new JV_WF_INFO();
        JV_JG_JOGAIBA jg          = new JV_JG_JOGAIBA();
        JV_WH_BATAIJYU wh         = new JV_WH_BATAIJYU();
        JV_WE_WEATHER we          = new JV_WE_WEATHER();
        JV_AV_INFO av             = new JV_AV_INFO();
        JV_JC_INFO jc             = new JV_JC_INFO();
        JV_TC_INFO tc             = new JV_TC_INFO();
        JV_CC_INFO cc             = new JV_CC_INFO();
        RECORD_ID head;

        public override string Format(string recordSpec, string record)
        {
            string key = null;
            switch (recordSpec)
            {
                case "TK":
                    tk.SetDataB(ref record);
                    key = $"{tk.id.Year}{tk.id.MonthDay}{tk.id.JyoCD}{tk.id.Kaiji}{tk.id.Nichiji}{tk.id.RaceNum}";
                    head = tk.head;
                    break;

                case "RA":
                    ra.SetDataB(ref record);
                    key = $"{ra.id.Year}{ra.id.MonthDay}{ra.id.JyoCD}{ra.id.Kaiji}{ra.id.Nichiji}{ra.id.RaceNum}";
                    head = ra.head;
                    break;

                case "SE":
                    se.SetDataB(ref record);
                    key = $"{se.id.Year}{se.id.MonthDay}{se.id.JyoCD}{se.id.Kaiji}{se.id.Nichiji}{se.id.RaceNum}{se.Umaban}{se.KettoNum}";
                    head = se.head;
                    break;

                case "HR":
                    hr.SetDataB(ref record);
                    key = $"{hr.id.Year}{hr.id.MonthDay}{hr.id.JyoCD}{hr.id.Kaiji}{hr.id.Nichiji}{hr.id.RaceNum}";
                    head = hr.head;
                    break;

                case "H1":
                    h1.SetDataB(ref record);
                    key = $"{h1.id.Year}{h1.id.MonthDay}{h1.id.JyoCD}{h1.id.Kaiji}{h1.id.Nichiji}{h1.id.RaceNum}";
                    head = h1.head;
                    break;

                case "H6":
                    h6.SetDataB(ref record);
                    key = $"{h6.id.Year}{h6.id.MonthDay}{h6.id.JyoCD}{h6.id.Kaiji}{h6.id.Nichiji}{h6.id.RaceNum}";
                    head = h6.head;
                    break;

                case "O1":
                    o1.SetDataB(ref record);
                    key = $"{o1.id.Year}{o1.id.MonthDay}{o1.id.JyoCD}{o1.id.Kaiji}{o1.id.Nichiji}{o1.id.RaceNum}{o1.HappyoTime}";
                    head = o1.head;
                    break;

                case "O2":
                    o2.SetDataB(ref record);
                    key = $"{o2.id.Year}{o2.id.MonthDay}{o2.id.JyoCD}{o2.id.Kaiji}{o2.id.Nichiji}{o2.id.RaceNum}{o2.HappyoTime}";
                    head = o2.head;
                    break;

                case "O3":
                    o3.SetDataB(ref record);
                    key = $"{o3.id.Year}{o3.id.MonthDay}{o3.id.JyoCD}{o3.id.Kaiji}{o3.id.Nichiji}{o3.id.RaceNum}";
                    head = o3.head;
                    break;

                case "O4":
                    o4.SetDataB(ref record);
                    key = $"{o4.id.Year}{o4.id.MonthDay}{o4.id.JyoCD}{o4.id.Kaiji}{o4.id.Nichiji}{o4.id.RaceNum}";
                    head = o4.head;
                    break;

                case "O5":
                    o5.SetDataB(ref record);
                    key = $"{o5.id.Year}{o5.id.MonthDay}{o5.id.JyoCD}{o5.id.Kaiji}{o5.id.Nichiji}{o5.id.RaceNum}";
                    head = o5.head;
                    break;

                case "O6":
                    o6.SetDataB(ref record);
                    key = $"{o6.id.Year}{o6.id.MonthDay}{o6.id.JyoCD}{o6.id.Kaiji}{o6.id.Nichiji}{o6.id.RaceNum}";
                    head = o6.head;
                    break;

                case "UM":
                    um.SetDataB(ref record);
                    key = $"{um.KettoNum}";
                    head = um.head;
                    break;

                case "KS":
                    ks.SetDataB(ref record);
                    key = $"{ks.KisyuCode}";
                    head = ks.head;
                    break;

                case "CH":
                    ch.SetDataB(ref record);
                    key = $"{ch.ChokyosiCode}";
                    head = ch.head;
                    break;

                case "BR":
                    br.SetDataB(ref record);
                    key = $"{br.BreederCode}";
                    head = br.head;
                    break;

                case "BN":
                    bn.SetDataB(ref record);
                    key = $"{bn.BanusiCode}";
                    head = bn.head;
                    break;

                case "HN":
                    hn.SetDataB(ref record);
                    key = $"{hn.HansyokuFNum}";
                    head = hn.head;
                    break;

                case "SK":
                    sk.SetDataB(ref record);
                    key = $"{sk.KettoNum}";
                    head = sk.head;
                    break;

                case "CK":
                    ck.SetDataB(ref record);
                    key = $"{ck.id.Year}{ck.id.MonthDay}{ck.id.JyoCD}{ck.id.Kaiji}{ck.id.Nichiji}{ck.id.RaceNum}{ck.UmaChaku.KettoNum}";
                    head = ck.head;
                    break;

                case "RC":
                    rc.SetDataB(ref record);
                    key = $"{rc.RecInfoKubun}{rc.id.Year}{rc.id.MonthDay}{rc.id.JyoCD}{rc.id.Kaiji}{rc.id.Nichiji}{rc.id.RaceNum}{rc.TokuNum}{rc.SyubetuCD}{rc.Kyori}{rc.TrackCD}";
                    head = rc.head;
                    break;

                case "HC":
                    hc.SetDataB(ref record);
                    key = $"{hc.TresenKubun}{hc.ChokyoDate.Year}{hc.ChokyoDate.Month}{hc.ChokyoDate.Day}{hc.ChokyoTime}{hc.KettoNum}";
                    head = hc.head;
                    break;

                case "HS":
                    hs.SetDataB(ref record);
                    key = $"{hs.KettoNum}{hs.SaleCode}{hs.FromDate.Year}{hs.FromDate.Month}{hs.FromDate.Day}";
                    head = hs.head;
                    break;

                case "HY":
                    hy.SetDataB(ref record);
                    key = $"{hy.KettoNum}";
                    head = hy.head;
                    break;

                case "YS":
                    ys.SetDataB(ref record);
                    key = $"{ys.id.Year}{ys.id.MonthDay}{ys.id.JyoCD}{ys.id.Kaiji}{ys.id.Nichiji}";
                    head = ys.head;
                    break;

                case "BT":
                    bt.SetDataB(ref record);
                    key = $"{bt.HansyokuNum}";
                    head = bt.head;
                    break;

                case "CS":
                    cs.SetDataB(ref record);
                    key = $"{cs.JyoCD}{cs.Kyori}{cs.TrackCD}{cs.KaishuDate.Year}{cs.KaishuDate.Month}{cs.KaishuDate.Day}";
                    head = cs.head;
                    break;

                case "DM":
                    dm.SetDataB(ref record);
                    key = $"{dm.id.Year}{dm.id.MonthDay}{dm.id.JyoCD}{dm.id.Kaiji}{dm.id.Nichiji}{dm.id.RaceNum}";
                    head = dm.head;
                    break;

                case "TM":
                    tm.SetDataB(ref record);
                    key = $"{tm.id.Year}{tm.id.MonthDay}{tm.id.JyoCD}{tm.id.Kaiji}{tm.id.Nichiji}{tm.id.RaceNum}";
                    head = tm.head;
                    break;

                case "WF":
                    wf.SetDataB(ref record);
                    key = $"{wf.KaisaiDate.Year}{wf.KaisaiDate.Month}{wf.KaisaiDate.Day}";
                    head = wf.head;
                    break;

                case "JG":
                    jg.SetDataB(ref record);
                    key = $"{jg.id.Year}{jg.id.MonthDay}{jg.id.JyoCD}{jg.id.Kaiji}{jg.id.Nichiji}{jg.id.RaceNum}{jg.KettoNum}{jg.ShutsubaTohyoJun}";
                    head = jg.head;
                    break;

                case "WH":
                    wh.SetDataB(ref record);
                    key = $"{wh.id.Year}{wh.id.MonthDay}{wh.id.JyoCD}{wh.id.Kaiji}{wh.id.Nichiji}{wh.id.RaceNum}";
                    head = wh.head;
                    break;

                case "WE":
                    we.SetDataB(ref record);
                    key = $"{we.id.Year}{we.id.MonthDay}{we.id.JyoCD}{we.id.Kaiji}{we.id.Nichiji}{we.HappyoTime.Month}{we.HappyoTime.Day}{we.HappyoTime.Hour}{we.HappyoTime.Minute}{we.HenkoID}";
                    head = we.head;
                    break;

                case "AV":
                    wh.SetDataB(ref record);
                    key = $"{av.id.Year}{av.id.MonthDay}{av.id.JyoCD}{av.id.Kaiji}{av.id.Nichiji}{av.id.RaceNum}{av.Umaban}";
                    head = av.head;
                    break;

                case "JC":
                    jc.SetDataB(ref record);
                    key = $"{jc.id.Year}{jc.id.MonthDay}{jc.id.JyoCD}{jc.id.Kaiji}{jc.id.Nichiji}{jc.id.RaceNum}{jc.HappyoTime.Month}{jc.HappyoTime.Day}{jc.HappyoTime.Hour}{jc.HappyoTime.Minute}{jc.Umaban}";
                    head = jc.head;
                    break;

                case "TC":
                    tc.SetDataB(ref record);
                    key = $"{tc.id.Year}{tc.id.MonthDay}{tc.id.JyoCD}{tc.id.Kaiji}{tc.id.Nichiji}{tc.id.RaceNum}";
                    head = tc.head;
                    break;

                case "CC":
                    cc.SetDataB(ref record);
                    key = $"{cc.id.Year}{cc.id.MonthDay}{cc.id.JyoCD}{cc.id.Kaiji}{cc.id.Nichiji}{cc.id.RaceNum}";
                    head = cc.head;
                    break;

                default:
                    return null;
            }
            string dataKubun = head.DataKubun;
            string makeDate = $"{head.MakeDate.Year}{head.MakeDate.Month}{head.MakeDate.Day}";

            return recordSpec + SEP + makeDate + SEP + dataKubun + SEP + key + SEP + record;
        }
    }
}
