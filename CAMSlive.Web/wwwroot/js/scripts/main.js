//"use strict";

async function RenderChart(chartId, chartOptions) {
    let chart = new ApexCharts(document.getElementById(chartId), JSON.parse(chartOptions));
    await chart.render();
    console.log('end of RenderChart()');
};

async function UpdateOptions(chartId, chartOptions) {
    let chart = window.ApexCharts.getChartByID(chartId);
    let tempOptions = JSON.parse(chartOptions);
    await chart.updateSeries(tempOptions.series);
};