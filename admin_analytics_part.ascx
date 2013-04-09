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
                chartArea: { left: 90, top: 50, width: "100%", height: "100%" }
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
                colors: ['red','#004411'],
                backgroundColor: '#A9F5F2'                             
            };

            var chart = new google.visualization.BarChart(document.getElementById('frequent_rental_div'));
            chart.draw(data, options);
        }
    </script>

<div class="container">
    <ul class="nav nav-tabs">
      <li class="active"><a href="#users"  data-toggle="tab">Users</a></li>
      <li><a href="#media" data-toggle="tab">Media</a></li>
    </ul>      
    <div id="myTabContent" class="tab-content">
            <div class="tab-pane fade in active" id="users">
                <div class="span5" id="chart_div" style="height:400px;"></div>
                <div class="span5" id="country_chart_div" style="height:400px;"></div>                 
            </div>
            <div class="tab-pane fade" id="media">
                <div class="span5" id="frequent_rental_div" style="width: 500px; height:550px;"></div>
                <div class="span5" id="frequent_comment_div" style="height:550px;"></div>                    
            </div>            
    </div>
</div>