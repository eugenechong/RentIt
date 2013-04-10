<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_analytics_part.ascx.cs" Inherits="RentIt.admin_analytics_part" %>

<%

    int female = 0;
    int male = 0;
    for (int i=0; i < user_list.Length; i++)
    {
        if (user_list[i].Gender == RentIt.RentItServices.Gender.Male)
        {
            male++;
        }
        else
        {
            female++;
        }
    }    
     %>

<script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        google.load("visualization", "1", { packages: ["corechart"] });
        google.setOnLoadCallback(drawChart);        
        function drawChart() {

            //gender
            var data = google.visualization.arrayToDataTable([
              ['Users', 'Gender'],
              ['Male', <%=male%>],
              ['Female', <%=female%>]
            ]);
            
            var options = {
                title: 'Users by Gender',
                backgroundColor: '#A9F5F2',
                chartArea:{left:90,top:50,width:"100%",height:"100%"}
            };

            var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
            chart.draw(data, options);

            //country
            var country_data = google.visualization.arrayToDataTable([
              ['Users', 'Country'],
                <%
                int country_count = 0;
                for (int i = 0; i < country_list.Length; i++)
                {
                    for (int j = 0; j < user_list.Length; j++)
                    {
                        if (country_list[i].Name.Equals(user_list[j].Country.Name))
                        {
                            country_count++;
                        }
                    }
                    if (i != (country_list.Length-1)) {
                %>
                        ['<%=country_list[i].Name%>', <%=country_count%>],
                <%
                    } else {
                %>
                        ['<%=country_list[i].Name%>', <%=country_count%>]
                <%
                    }
                        country_count = 0;
                }
                %>                 
            ]);
            var country_options = {
                title: 'Users by Country',
                backgroundColor: '#A9F5F2',
                chartArea: { left: 90, top: 50, width: "100%", height: "100%" }
            };

            var country_chart = new google.visualization.PieChart(document.getElementById('country_chart_div'));
            country_chart.draw(country_data, country_options);
        }

    </script>


<div class="container">

    <div id="users">
        <div class="span5" id="chart_div" style="height:400px;"></div>
        <div class="span5" id="country_chart_div" style="height:400px;"></div>                 
    </div>

</div>