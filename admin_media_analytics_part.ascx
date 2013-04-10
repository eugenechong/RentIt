<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_media_analytics_part.ascx.cs" Inherits="RentIt.admin_media_analytics_part" %>

<script type="text/javascript" src="https://www.google.com/jsapi"></script>
<script type="text/javascript">
    google.load("visualization", "1", { packages: ["corechart"] });
    google.setOnLoadCallback(drawChart);
    function drawChart() {

        //media comments
        var comment_data = google.visualization.arrayToDataTable([
            ['Title', 'Comments'],
            <%                
            for (int i = 0; i < media_list.Length; i++)     
            {               
                if (i != (media_list.Length-1)) {
            %>
                    ['<%=media_list[i].Title%>', <%=media_list[i].Comments.Length%>],
            <%
                } else {
            %>
                    ['<%=media_list[i].Title%>', <%=media_list[i].Comments.Length%>]
            <%
                }
            }
            %>
        ]);
        var comment_options = {
            title: 'Frequently Commented Media',
            backgroundColor: '#A9F5F2',
            chartArea: { left: 40, top: 90, width: "80%", height: "80%" }
        };

        var comment_chart = new google.visualization.PieChart(document.getElementById('frequent_comment_div'));
        comment_chart.draw(comment_data, comment_options);
    }

</script>

<script type="text/javascript">
    google.load("visualization", "1", { packages: ["corechart"] });
    google.setOnLoadCallback(drawChart);
    function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Media', 'Rent Count'],
                <%
                int rent_count = 0;
                for (int i = 0; i < media_list.Length; i++)
                {
                    for (int j = 0; j < user_list.Length; j++)
                    {
                        rental_list = utility.getRentalHistory(user_list[j]);
                        if (rental_list.Length > 0) {
                            for (int k = 0; k < rental_list.Length; k++)
                            {
                                if (rental_list[k].Media.Title.Equals(media_list[i].Title)) {
                                    rent_count++;
                                }
                            }
                        }
                    }
                    if (i != (media_list.Length-1)) {
                %>
                        ['<%=media_list[i].Title%>', <%=rent_count%>],
                <%
                    } else {
                %>
                        ['<%=media_list[i].Title%>', <%=rent_count%>]
                <%
                    }
                        rent_count = 0;
                }
                %>
            ]);

            var options = {
                title: 'Frequently Rented Media',
                colors: ['blue', '#004411'],
                backgroundColor: '#A9F5F2'                
            };

            var chart = new google.visualization.BarChart(document.getElementById('frequent_rental_div'));
            chart.draw(data, options);
        }
</script>

<div class="container">
    <div id="media">
        <div class="span5" id="frequent_rental_div" style="width: 500px; height: 450px;"></div>
        <div class="span5" id="frequent_comment_div" style="width: 400px; height: 450px;"></div>
    </div>
</div>
