using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using GIS;

namespace Negocio {

    public class ManipularMapa {

        Mapa mapa;

        public ManipularMapa(int width, int height) {
            mapa = new Mapa(width, height);
        }

        public string GerarMapa() {
            return ConfigurationManager.AppSettings["imgsUrl"] +"/" + mapa.GerarImagem();
        }

        public string GerarMapaMaisZoom() {
            mapa.ZoomMais();
            return this.GerarMapa();
        }

        public string GerarMapaMenosZoom() {
            mapa.ZoomMenos();
            return this.GerarMapa();
        }

        public string MoverParaBaixo() {
            mapa.MoverMapaParaBaixo();
            return this.GerarMapa();
        }

        public string MoverParaCima() {
            mapa.MoverMapaParaCima();
            return this.GerarMapa();
        }

        public string MoverEsquerda() {
            mapa.MoverMapaParaEsquerda();
            return this.GerarMapa();
        }

        public string MoverDireita() {
            mapa.MoverMapaParaDireita();
            return this.GerarMapa();
        }

    }
}
