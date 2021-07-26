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
