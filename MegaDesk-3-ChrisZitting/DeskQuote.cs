using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ChrisZitting
{
    public class DeskQuote
    {
        private const double BASE_PRICE = 200;
        private const double COST_DRAWER = 50;
        private const double AREA_THRESHOLD = 1000; //Inches squared for the area of desk
        private const double EXCESS_SURF_AREA = 1; //Cost per square inch over threshold

        private string CustomerName;
        private DateTime QuoteDate;
        private int RushDays;
        private Desk Desk;

        public DeskQuote(string customerName, int rushDays, double width, double depth, int numOfDrawers, SurfaceMaterial material)
        {
            CustomerName = customerName;
            RushDays = rushDays;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumDrawers = numOfDrawers;
            Desk.Material = material;
        }

        public double CalculateAreaCost()
        {
            if (Desk.Width * Desk.Depth > AREA_THRESHOLD)
            {
                return (Desk.Width * Desk.Depth - AREA_THRESHOLD) * EXCESS_SURF_AREA;
            }
            else
            {
                return 0;
            }
        }

        public double CalculateDrawerCost()
        {
            return Desk.NumDrawers * COST_DRAWER;
        }

        //public double CalculateMaterialCost()
        //{
        //    Desk.Material result;
        //    if Desk.Material.TryParse()
        //    switch (result)

        //}

        public double CaculateQuoteTotal()
        {
            //Need to add Area cost, drawers, material, rush fee
            return BASE_PRICE + CalculateAreaCost() + CalculateDrawerCost() + CalculateMaterialCost() + CalculateRushCost();
        }
    }
}
