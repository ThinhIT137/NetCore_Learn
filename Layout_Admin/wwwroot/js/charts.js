function initCharts() {
    // Biểu đồ 1
    new Chart(document.getElementById("barChart"), {
        type: 'bar',
        data: {
            labels: ["Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6"],
            datasets: [{
                label: "Doanh thu (VND)",
                data: [12000000, 15000000, 18000000, 20000000, 22000000, 25000000],
                backgroundColor: "rgba(54, 162, 235, 0.6)"
            }]
        }
    });

    // Biểu đồ 2
    new Chart(document.getElementById("lineChart"), {
        type: 'line',
        data: {
            labels: ["Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6"],
            datasets: [{
                label: "Doanh thu (VND)",
                data: [12000000, 14000000, 16000000, 19000000, 21000000, 24000000],
                borderColor: "rgba(75, 192, 192, 1)",
                fill: true
            }]
        }
    });

    // Biểu đồ 3
    new Chart(document.getElementById("pieChart"), {
        type: 'pie',
        data: {
            labels: ["Trà sữa", "Kem tươi", "Topping", "Khác"],
            datasets: [{
                data: [40, 35, 15, 10],
                backgroundColor: ["#FF6384", "#36A2EB", "#FFCE56", "#AA65CC"]
            }]
        }
    });

    // Biểu đồ 4
    new Chart(document.getElementById("doughnutChart"), {
        type: 'doughnut',
        data: {
            labels: ["Hà Nội", "Hải Phòng", "Đà Nẵng", "TP.HCM", "Quảng Ninh"],
            datasets: [{
                data: [20, 15, 10, 30, 25],
                backgroundColor: ["#FF6384", "#36A2EB", "#FFCE56", "#4BC0C0", "#AA65CC"]
            }]
        }
    });

    // Biểu đồ 5
    new Chart(document.getElementById("compareLineChart"), {
        type: 'line',
        data: {
            labels: ["Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6"],
            datasets: [
                {
                    label: "Năm nay",
                    data: [12000000, 16000000, 18000000, 22000000, 24000000, 28000000],
                    borderColor: "rgba(255, 99, 132, 1)",
                    fill: false
                },
                {
                    label: "Năm trước",
                    data: [10000000, 14000000, 15000000, 18000000, 20000000, 23000000],
                    borderColor: "rgba(54, 162, 235, 1)",
                    fill: false
                }
            ]
        }
    });

    // Biểu đồ 6
    new Chart(document.getElementById("radarChart"), {
        type: 'radar',
        data: {
            labels: ["Trà sữa", "Kem tươi", "Topping", "Smoothie", "Khác"],
            datasets: [{
                label: "Mức độ bán chạy",
                data: [80, 90, 60, 70, 50],
                backgroundColor: "rgba(54, 162, 235, 0.2)",
                borderColor: "rgba(54, 162, 235, 1)"
            }]
        }
    });
}
