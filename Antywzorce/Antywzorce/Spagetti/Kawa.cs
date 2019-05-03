using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antywzorce.Spagetti
{
    public class Kawa : IDrink
    {
        public int Napoj { get ; set ; }
        public int Wielkosc { get ; set; }
        public int Mleko { get; set; }
        public int IleMleka { get; set; }
        public int Cukier { get; set; }
        public int IleCukru { get; set; }

        public string SelectSize()
        {
                string food = "";
                if (Napoj == 1)
                {
                    int ml = 0;
                    switch (Wielkosc)
                    {
                        case 1:
                            ml += 50;
                            break;
                        case 2:
                            ml += 50;
                            goto case 1;
                        case 3:
                            ml += 50;
                            goto case 2;
                        case 4:
                            ml += 50;
                            goto case 3;
                        default: break;
                    }
                    string size = "";
                    if (ml > 0)
                    {
                        size = "mala";
                        if (ml > 100)
                        {
                            size = "średnia";
                            if (ml > 150)
                            {
                                size = "duża";
                            }
                        }
                    }
                    string milk = "bez mleka";
                    if (Mleko != 0)
                    {
                        milk = "z mlekiem";
                        int milkMl = 0;
                        switch (IleMleka)
                        {
                            case 1:
                                milkMl += 50;
                                break;
                            case 2: milkMl += 50; goto case 1;
                            case 3: milkMl += 50; goto case 2;
                            case 4: milkMl += 50; goto case 3;
                            default: break;
                        }
                        milk += $" {milkMl} ml";
                    }
                    string shugar = ""; if (Napoj != 20) { shugar = "bez cukru."; }
                    else
                    {
                        shugar = "z cukrem"; if (IleCukru > 0)
                        {
                            shugar += " 1";
                            if (IleCukru > 1) { shugar = shugar.Replace(" 1", " 2"); if (IleCukru > 2) { shugar = shugar.Replace(" 2", " 3"); if (IleCukru == 4) { shugar = shugar.Replace(" 3", " 4"); } } }
                        }
                        shugar += " kostki.";
                    }
                    food = "Woda "; food += $"; {size} {ml} ml; {milk}; {shugar}";
                }
                else if (Napoj == 2)
                {
                    int ml = 0; switch (Wielkosc) { case 1: ml += 50; break; case 2: ml += 50; goto case 1; case 3: ml += 50; goto case 2; case 4: ml += 50; goto case 3; default: break; }
                    string size = ""; if (ml > 0) { size = "mala"; if (ml > 100) { size = "średnia"; if (ml > 150) { size = "duża"; } } }
                    string milk = "bez mleka"; if (Mleko != 0)
                    {
                        milk = "z mlekiem"; int milkMl = 0; switch (IleMleka)
                        {
                            case 1: milkMl += 50; break;
                            case 2:
                                milkMl += 50; goto case 1;
                            case 3: milkMl += 50; goto case 2;
                            case 4: milkMl += 50; goto case 3;
                            default: break;
                        }
                        milk += $" {milkMl} ml";
                    }
                    string shugar = ""; if (Cukier != 20) { shugar = "bez cukru."; }
                    else
                    {
                        shugar = "z cukrem"; if (IleCukru > 0) { shugar += " 1"; if (IleCukru > 1) { shugar = shugar.Replace(" 1", " 2"); if (IleCukru > 2) { shugar = shugar.Replace(" 2", " 3"); if (IleCukru == 4) { shugar = shugar.Replace(" 3", " 4"); } } } }

                        shugar += " kostki.";
                    }
                    food = "Herbata"; food += $"; {size} {ml} ml; {milk}; {shugar}";
                }
                else if (Napoj == 3)
                {
                    int ml = 0; switch (Wielkosc)
                    {
                        case 1: ml += 50; break;
                        case 2: ml += 50; goto case 1;
                        case 3: ml += 50; goto case 2;
                        case 4: ml += 50; goto case 3;
                        default:
                            break;
                    }
                    string size = ""; if (ml > 0) { size = "mala"; if (ml > 100) { size = "średnia"; if (ml > 150) { size = "duża"; } } }
                    string milk = "bez mleka"; if (Mleko != 0)
                    {
                        milk = "z mlekiem"; int milkMl = 0; switch (IleMleka) { case 1: milkMl += 50; break; case 2: milkMl += 50; goto case 1; case 3: milkMl += 50; goto case 2; case 4: milkMl += 50; goto case 3; default: break; }
                        milk += $" {milkMl} ml";
                    }
                    string shugar = ""; if (Napoj != 20) { shugar = "bez cukru."; }
                    else
                    {
                        shugar = "z cukrem"; if (IleCukru > 0)
                        {
                            shugar += " 1"; if (IleCukru > 1) { shugar = shugar.Replace(" 1", " 2"); if (IleCukru > 2) { shugar = shugar.Replace(" 2", " 3"); if (IleCukru == 4) { shugar = shugar.Replace(" 3", " 4"); } } }
                        }
                        shugar += " kostki.";
                    }
                    food = "Kawa"; food += $"; {size} {ml} ml; {milk}; {shugar}";
                }
                else if (Napoj == 4)
                {
                    int ml = 0; switch (Wielkosc) { case 1: ml += 50; break; case 2: ml += 50; goto case 1; case 3: ml += 50; goto case 2; case 4: ml += 50; goto case 3; default: break; }
                    string size = ""; if (ml > 0) { size = "mala"; if (ml > 100) { size = "średnia"; if (ml > 150) { size = "duża"; } } }
                    string milk = "bez mleka"; if (Mleko != 0)
                    {
                        milk = "z mlekiem"; int milkMl = 0; switch () { case 1: milkMl += 50; break; case 2: milkMl += 50; goto case 1; case 3: milkMl += 50; goto case 2; case 4: milkMl += 50; goto case 3; default: break; }
                        milk += $" {milkMl} ml";
                    }
                    string shugar = ""; if (Cukier != 20) { shugar = "bez cukru."; } else { shugar = "z cukrem"; if (IleCukru > 0) { shugar += " 1"; if (IleCukru > 1) { shugar = shugar.Replace(" 1", " 2"); if (IleCukru > 2) { shugar = shugar.Replace(" 2", " 3"); if (IleCukru == 4) { shugar = shugar.Replace(" 3", " 4"); } } } } shugar += " kostki."; }
                    food = "Porcja soku"; food += $"; {size} {ml} ml; {milk}; {shugar}";
                }
                return food;
            
        }


    }
    
}
