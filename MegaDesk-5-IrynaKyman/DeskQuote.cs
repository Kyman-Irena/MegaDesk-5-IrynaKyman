using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_5_IrynaKyman
{
    class DeskQuote
    {
        #region member variables
        //A desk quote description
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        
        public Desk Desk = new Desk();
        public int RushDays { get; set; }
        public int QuoteAmount { get; set; }


        #endregion

        private int SurfaceArea = 0;
        #region constants

        private const int PRICE_BASE = 200;
        private const int BIG_SIZE = 1000;
        private const int PRICE_PER_DRAWER = 50;
        private const int PRICE_PER_SURFACEAREA = 1;
        private const int RUSH1 = 3;
        private const int RUSH2 = 5;
        private const int RUSH3 = 7;
        private const int RUSH_ORDER_SIZE = 2000;
        #endregion

        public DeskQuote(string customerName, DateTime quoteDate, int width, int depth, int drawers, DesktopMaterial material, int rushDays)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumberOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            RushDays = rushDays;

            SurfaceArea = Desk.Width * Desk.Depth;
        }

        public int CalculateQuoteTotal()
        {
            QuoteAmount = PRICE_BASE + SurfaceAreaCost() + DrawerCost() + (int)Desk.DesktopMaterial; //RushOrderCost();

            return QuoteAmount;
        }

        private int SurfaceAreaCost()
        {
            if (SurfaceArea>BIG_SIZE)
            {
                return (SurfaceArea - BIG_SIZE) * PRICE_PER_SURFACEAREA;
            }
            else
            {
                return SurfaceArea;
            }
        }

        public int DrawerCost()
        {
            return Desk.NumberOfDrawers * PRICE_PER_DRAWER;
        }
        //public int RushOrderCost()
        //{

        //}
    }
}
