using INEGI.src.controllers;
using INEGI.src.databases;
using INEGI.src.models;
using INEGI.src.views;

namespace INEGI.src
{
    static class MainClass
    {   
        [STAThread]
        static void Main()
        {
            ModelUsuer mdUsuer = new ModelUsuer();
            FrmLogin vwLogin = new FrmLogin();
            ControllerUser ctUser = new ControllerUser(mdUsuer, vwLogin);
            ctUser.RunApp();
        }
    }
}