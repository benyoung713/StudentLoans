using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    double payBackPerYear = 0;

    protected void Calculate_Click(object sender, EventArgs e)
    {
        try
        {
            int yearStarted = Convert.ToInt32(YearInput.Text);
            int courseLength = Convert.ToInt32(LengthList.SelectedValue);
            int maintenanceLoan = MaintenanceInput.Text == "" ? 0 : Convert.ToInt32(MaintenanceInput.Text);
            int salary = Convert.ToInt32(Salary.Text);
            int uniLoan = 0;
            int payBackSalary = 0;

            double payBackTimeInYears = 0;
            double payBackMonths = 0;



            if (yearStarted <= 2011 & yearStarted >= 2004)
            {
                uniLoan = 3465;
                payBackSalary = 15000;
            }

            else
            {
                uniLoan = 9000;
                payBackSalary = 21000;
            }

            int totalLoan = (courseLength * uniLoan) + (courseLength * maintenanceLoan);
            if (yearStarted >= 2004)
            {
                if (salary < payBackSalary)
                {
                    Result.Text = "You are earning under the payback threshold and so do not repay any loan on your current salary.";

                }
                else
                {
                    payBackPerYear = (salary - payBackSalary) * 0.09;
                    payBackTimeInYears = Math.Floor(totalLoan / payBackPerYear);
                    if (payBackTimeInYears > 25)
                    {
                        Result.Text = "Your total loan is £" + totalLoan + ". There is a cut-off of 25 years on paying back a student loan. So if you stay on your current salary, you will pay £" + payBackPerYear + " per year. You will have paid off £" + 25 * payBackPerYear + " before your debt is wiped.";
                        drawChart(payBackPerYear, totalLoan);
                    }
                    else
                    {
                        double payBackMonthsRounded = Math.Floor(totalLoan / payBackPerYear);
                        payBackMonths = Math.Ceiling((totalLoan - (payBackMonthsRounded * payBackPerYear)) / payBackPerYear * 12);
                        Result.Text = "Your total loan is £" + totalLoan + ". On a salary of £" + salary + ", you will pay back £" + payBackPerYear + " per year. Therefore it will take you "
                            + payBackTimeInYears + " years, " + payBackMonths + " month(s) to pay off your loan.";

                        drawChart(payBackPerYear, totalLoan);
                    }
                }
            }
            else
            {
                Result.Text = "There were no student loans issued by the Student Loans Company before 2004.";
            }


        }
        catch (Exception)
        {
            Result.Text = "You entered some invalid input. Please try again.";
        }
    }

    private void drawChart(double payBackPerYear, int totalLoan)
    {
        ClientScript.RegisterStartupScript(GetType(), "draw", "draw(" + payBackPerYear + "," + totalLoan + ");", true);
    }

}