using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Polynomial
{
    public class Polynomial
    {
        readonly List<PolynomialData> _PolyList = new List<PolynomialData>();

        class PolynomialData
        {
            public int Expo { get; private set; }
            public int Coef { get; set; }

            public PolynomialData(int expo, int coef)
            {
                Expo = expo;
                Coef = coef;
            }
        }

        public void SetItem(int expo, int coef)
        {
            _PolyList.Add(new PolynomialData(expo, coef));
        }

        public int Coef(int expo)
        {
            return (from poly in _PolyList where poly.Expo == expo select poly.Coef).FirstOrDefault();
        }

        public int LeadExp()
        {
            return _PolyList.Select(poly => poly.Expo).Concat(new[] { 0 }).Max();
        }

        public Polynomial Add(Polynomial p2)
        {
            foreach (var poly2 in p2._PolyList)
            {
                var p = _PolyList.Find(poly => poly.Expo == poly2.Expo);

                if (p != null)
                {
                    _PolyList.Find(poly => poly.Expo == poly2.Expo).Coef += poly2.Coef;
                }
                else
                {
                    _PolyList.Add(new PolynomialData(poly2.Expo, poly2.Coef));
                }
            }
            return this;
        }

        public Polynomial Mult(Polynomial p2)
        {
            Polynomial result = new Polynomial();
            foreach (var poly1 in _PolyList)
            {
                foreach (var poly2 in p2._PolyList)
                {
                    var expoTmp = poly1.Expo + poly2.Expo;
                    var coefTmp = poly1.Coef * poly2.Coef;
                    var p = result._PolyList.Find(poly => poly.Expo == expoTmp);

                    if (p != null)
                    {
                        result._PolyList.Find(poly => poly.Expo == expoTmp).Coef += coefTmp;
                    }
                    else
                    {
                        result.SetItem(expoTmp, coefTmp);
                    }
                }
            }
            return result;
        }

        public int Eval(int value)
        {
            var result = 0;
            foreach (var poly in _PolyList)
            {
                int tmp;
                if (poly.Expo != 0)
                {
                    tmp = Convert.ToInt32(System.Math.Pow(value, poly.Expo));
                    tmp *= poly.Coef;
                }
                else
                {
                    tmp = poly.Coef;
                }
                result += tmp;
            }
            return result;
        }
    }
}
