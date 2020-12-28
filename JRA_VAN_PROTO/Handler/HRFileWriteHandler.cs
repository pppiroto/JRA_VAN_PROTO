using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static JRA_VAN_PROTO.JVData_Struct;

namespace JRA_VAN_PROTO.Handler
{
    public class HRFileWriteHandler : FileWriteHander
    {
        private JV_HR_PAY rec = new JV_HR_PAY();

        public override string GetDataSpec(string dataSpec)
        {
            return "RACE";
        }

        public override void WriteTitle()
        {
             Write("kaisai,jyou,race_no,ttousu,stousu,tan_uma,tan_pay,tan_ninki");
        }

        public override string Format(string recordSpec, string record)
        {
            if (recordSpec == "HR")
            {
                rec.SetDataB(ref record);
                return $"{rec.id.Year}{rec.id.MonthDay},{rec.id.JyoCD},{rec.id.RaceNum}," +
                       $"{JVUtils.SuppressZero(rec.TorokuTosu)}," +
                       $"{JVUtils.SuppressZero(rec.SyussoTosu)}," +
                       $"{rec.PayTansyo[0].Umaban}," +
                       $"{JVUtils.SuppressZero(rec.PayTansyo[0].Pay)}," +
                       $"{JVUtils.SuppressZero(rec.PayTansyo[0].Ninki)}";
            }
            Debug.WriteLine($"SKIP(NOT HR):{recordSpec}");
            return null;
        }
    }
}
