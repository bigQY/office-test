{
  import java.*
  cout "hello world"
    mod debug_layer;
mod main_menu_director;
mod sce_proc_hooks;

use debug_layer::OpenPal3DebugLayer;
use opengb::{asset_manager::AssetManager, config::OpenGbConfig};
use radiance::application::utils::FpsCounter;
use radiance::application::{Application, ApplicationExtension};
use std::rc::Rc;
use std::{cell::RefCell, path::PathBuf};

fn main() {
    let config = OpenGbConfig::load("openpal3", "OPENPAL3");
    let mut app = OpenPal3Application::create(&config, "OpenPAL3");
    app.initialize();
    app.run();
}

pub struct OpenPal3Application {
    root_path: PathBuf,
    app_name: String,
    asset_mgr: Option<Rc<AssetManager>>,
}

impl ApplicationExtension<OpenPal3Application> for OpenPal3Application {
    fn on_initialized(&mut self, app: &mut Application<OpenPal3Application>) {
        simple_logger::SimpleLogger::new().init().unwrap();
        app.set_title(&self.app_name);
      
      extends Node2D

onready var game = get_tree().get_root().get_node("Control/game")
signal breed_complete 

func _ready():
	pass
	 public PostTransactionResponse postTransaction(PostTransactionRequest request) {
        try {
            String requestUrl = getUrl(API.POST_TRANSACTION);
            String requestBody = JsonUtil.toJson(request);
            String responseHtml = NetUtil.get(requestUrl,requestBody);
            return JsonUtil.fromJson(responseHtml,PostTransactionResponse.class);
        }
func breed():
	get_node("AnimationPlayer").play("breed")

func _on_AnimationPlayer_animation_finished( name ):
	pass # replace with function body
	print ("BREED complete in badges")
	emit_signal("breed_complete", self) # null to fake tween completed
<template>
  <div id="app">
    <div id="nav">
      <router-link to="/">Home</router-link> |
      <router-link to="/about">About</router-link>
    </div>
    <router-view/>
  </div>
</template>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;
}

#nav a {
  font-weight: bold;
  color: #2c3e50;
}

#nav a.router-link-exact-active {
  color: #42b983;
}
</style>
}
	    
{
  "@content.downloadUrl":"https://public-sn3302.files.1drv.com/y2pcT7OaUEExF7EHOlpTjCE55mIUoiX7H3sx1ff6I-nP35XUTBqZlnkh9FJhWb_pf9sZ7LEpEchvDznIbQig0hWBeidpwFkOqSKCwQylisarN6T0ecAeMvantizBUzM2PA1",
  "createdDateTime": "2016-09-16T03:37:04.72Z",
  "cTag": "aYz5MUQ5RDNEITU0OTI3LjI1Ng",
  "eTag": "aRDQ2NDhGMDZDOTFEOUQzRCE1NDkyNy4w",
  "id":"D4648F06C91D9D3D!54927",
  "lastModifiedBy": {
    "user": {
      "displayName": "Daron Spektor",
      "id": "d4648f06c91d9d3d"
    }
  },
  "name":"BriSir.jpg",
  "size":3512,
  "image":{
    "height":398,
    "width":23
  },
  "file": {
    "hashes":{
      "sha1Hash":"wmgPQ6jrSeMX7JP1XmstQEGM2fc="
    }
  }
}
	    MSHTTPClient *httpClient = [MSClientFactory createHTTPClientWithAuthenticationProvider:authenticationProvider];

NSString *MSGraphBaseURL = @"https://graph.microsoft.com/v1.0/";
NSMutableURLRequest *urlRequest = [NSMutableURLRequest requestWithURL:[NSURL URLWithString:[MSGraphBaseURL stringByAppendingString:@"/groups/{groupId}/drives"]]];
[urlRequest setHTTPMethod:@"GET"];

MSURLSessionDataTask *meDataTask = [httpClient dataTaskWithRequest:urlRequest 
    completionHandler: ^(NSData *data, NSURLResponse *response, NSError *nserror) {

        NSError *jsonError = nil;
        MSCollection *collection = [[MSCollection alloc] initWithData:data error:&jsonError];
        MSGraphDrive *drive = [[MSGraphDrive alloc] initWithDictionary:[[collection value] objectAtIndex: 0] error:&nserror];

}];
The resource you have requested is not found.
[meDataTask execute]
	    GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var drives = await graphClient.Groups["{group-id}"].Drives
    .Request()
    .GetAsync()
$message = Get-Content .\connector-card.json
$url = <YOUR WEBHOOK URL>
Invoke-RestMethod -ContentType "application/json" -Body $message -Uri $url -Method Post
	<%-- The following 4 lines are ASP.NET directives needed when using SharePoint components --%>

<%@ Page Inherits="Microsoft.SharePoint.WebPartPages.WebPartPage, Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" MasterPageFile="~masterurl/default.master" Language="C#" %>

<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%-- The markup and script in the following Content element will be placed in the <head> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
  <script type="text/javascript" src="../Scripts/jquery-1.9.1.min.js"></script>
  <script type="text/javascript" src="/_layouts/15/sp.runtime.js"></script>
  <script type="text/javascript" src="/_layouts/15/sp.js"></script>
  <script type="text/javascript" src="../Scripts/knockout-3.2.0.js"></script>
  <script type="text/javascript" src="../Scripts/q.min.js"></script>
  <meta name="WebPartPageExpansion" content="full" />

  <!-- Add your CSS styles to the following file -->
  <link rel="Stylesheet" type="text/css" href="../Content/App.css" />

  <!-- Add your JavaScript to the following file -->
  <script type="text/javascript" src="../Scripts/App.js"></script>
</asp:Content>

<%-- The markup in the following Content element will be placed in the TitleArea of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
  Page Title
</asp:Content>

<%-- The markup and script in the following Content element will be placed in the <body> of the page --%>
<asp:Content ContentPlaceHolderID="PlaceHolderMain" runat="server">
  
  <input type="button" disabled="disabled" 
         value="refresh list"
         data-bind="click: getAllChiefExecutives"/>&nbsp;
  <input type="button" disabled="disabled" 
         value="appoint 3rd ceo"
         data-bind="click: addThirdCeo"/>&nbsp;
  <input type="button" disabled="disabled" 
         value="delete first person"
         data-bind="click: deleteFirstCeo"/>

  <h1>Microsoft CEO's</h1>
  <table>
    <thead>
      <tr>
        <th>Name</th>
        <th>Tenure</th>
      </tr>
    </thead>
    <tbody data-bind="foreach: chiefExecutives">
      <tr>
        <td data-bind="text: Title"></td>
        <td><span data-bind="text: TenureStartYear"></span> - <span data-bind="  text: TenureEndYear"></span></td>
      </tr>
    </tbody>
  </table>

</asp:Content>
	<?xml version="1.0" encoding="utf-8"?>
<Elements xmlns="http://schemas.microsoft.com/sharepoint/">
  <Module Name="Pages">
    <File Path="Pages\Default.aspx" Url="Pages/Default.aspx" ReplaceContent="TRUE" />
  </Module>
</Elements>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServerSideWeb.Models {
  public class SpChiefExecutive
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string TenureStartYear { get; set; }
    public string TenureEndYear { get; set; }
  }
}

using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestServerSideWeb.Controllers {
  public class HomeController : Controller {
    [SharePointContextFilter]
    public ActionResult Index() {
      User spUser = null;

      var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);

      using (var clientContext = spContext.CreateUserClientContextForSPHost()) {
        if (clientContext != null) {
          spUser = clientContext.Web.CurrentUser;

          clientContext.Load(spUser, user => user.Title);

          clientContext.ExecuteQuery();

          ViewBag.UserName = spUser.Title;
        }
      }

      return View();
    }

    public ActionResult About() {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact() {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
