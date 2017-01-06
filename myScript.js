draw = function (payBackPerYear, totalLoan) {

    var graphData = new Array();
    var graphValue;

    for(i = 1; i < 26; i++){
        graphValue = totalLoan - (i * payBackPerYear);
        graphData.push(graphValue);
                        
    }

           
        var chart = new CanvasJS.Chart("chartContainer", {
            theme: "theme1",//theme1
            /*title:{
                text: ""              
            },*/
            animationEnabled: true,
            data: [              
            {
                type: "line", 
                dataPoints: [
                    { label: 0,  y: totalLoan},
                    { label: i, y: graphData[i-1]},
                                    ]
            }
            ]
        });
        chart.render();
    }
    





       
