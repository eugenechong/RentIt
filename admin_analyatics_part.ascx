<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_analyatics_part.ascx.cs" Inherits="RentIt.admin_analyatics_part" %>
<%  
    //Generate the charts
    int female = 0;
    int male = 0;
    for (int i = 0; i < user_list.Length; i++)
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
            var data = google.visualization.arrayToDataTable([
              ['Users', 'Gender'],
              ['Male', <%=male%>],
              ['Female', <%=female%>]
            ]);


            var options = {
                title: 'Users by Gender',
                 chartArea:{left:90,top:50,width:"100%",height:"100%"}
            };

            var chart = new google.visualization.PieChart(document.getElementById('chart_div'));
            chart.draw(data, options);

            //country
            var country_data = google.visualization.arrayToDataTable([
              ['Users', 'Country'],
              ['Male', <%=male%>],
              ['Female', <%=female%>]
            ]);
            var country_options = {
                title: 'Users by Gender',
                chartArea: { left: 90, top: 50, width: "100%", height: "100%" }
            };

            var country_chart = new google.visualization.PieChart(document.getElementById('country_chart_div'));
            country_chart.draw(country_data, country_options);


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
                <p>Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.</p>
              </div>
            
            </div>
          </div>

    
   
    

</div>