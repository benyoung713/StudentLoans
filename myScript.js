draw = function (payBackPerYear, totalLoan) {

    var dps = new Array();
    var yValue;
    var xValue = 0;

    for(i = 1; i < 26; i++){
        yValue = totalLoan - (i * payBackPerYear);
        xValue++;
        if (yValue <= 0) { break;}
        dps.push({ x: xValue, y: yValue });
                        
    }

           
    var chart = new CanvasJS.Chart("chartContainer", {
        theme: "theme1",//theme1
        title:{
            text: "Graph showing the value of the loan through repayments"              
        },
        axisX:{title: "Time in years"

        },
        axisY: {
            title: "Amount left to pay (£)",
            interlacedColor: "azure"
        },
        animationEnabled: true,
        data: [              
        {
            type: "line", 
            dataPoints: dps
        }
        ]
    });
    chart.render();
}
    





       