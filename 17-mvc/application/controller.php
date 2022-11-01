<?php

class Controller {
public $load;
public $model;
function __construct() {
$this->load = new Load();
$this->model = new Model();
$this->inicio();
}
function inicio() {
$datos = $this->model->infoUsuario();
$this->load->view('welcome.php', $datos);
}
}