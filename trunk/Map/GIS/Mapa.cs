using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using OSGeo.MapServer;

namespace GIS {

    public class Mapa {

        OSGeo.MapServer.mapObj map;

        public Mapa(int width, int height) {

            map = new OSGeo.MapServer.mapObj(
                ConfigurationManager.AppSettings["mapFilePath"]);
            map.width = width;
            map.height = height;

        }

        string nome;

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public string GerarImagem() {
            nome = String.Empty;
            Random rand = new Random(DateTime.Now.Millisecond);
            OSGeo.MapServer.imageObj img = map.draw();
            nome = rand.Next().ToString() + ".jpg";
            img.save(ConfigurationManager.AppSettings["imgsMapas"] + "\\" + nome, map);

            return nome;
        }

        public void ZoomMais() {
            map.zoomPoint(2, new pointObj(
                Convert.ToInt32(map.width / 2), Convert.ToInt32(map.height / 2), 0, 0),
                map.width, map.height, map.extent, null);
        }

        public void ZoomMenos() {
            map.zoomPoint(-2, new pointObj(Convert.ToInt32(map.width / 2),
                Convert.ToInt32(map.height / 2), 0, 0), map.width, map.height, map.extent, null);
        }

        public void MoverMapaParaCima() {
            map.zoomPoint(1, new pointObj(Convert.ToInt32(map.width / 2),
                Convert.ToInt32(map.height / 10) * 8, 0, 0), map.width, map.height, map.extent, null);
        }

        public void MoverMapaParaBaixo() {
            map.zoomPoint(1, new pointObj(Convert.ToInt32(map.width / 2),
                Convert.ToInt32(map.height / 10) * 2, 0, 0), map.width, map.height, map.extent, null);
        }

        public void MoverMapaParaDireita() {
            map.zoomPoint(1, new pointObj(Convert.ToInt32(map.width / 10) * 2,
                Convert.ToInt32(map.height / 2), 0, 0), map.width, map.height, map.extent, null);
        }

        public void MoverMapaParaEsquerda() {
            map.zoomPoint(1, new pointObj(Convert.ToInt32(map.width / 10) * 8,
                Convert.ToInt32(map.height / 2), 0, 0), map.width, map.height, map.extent, null);
        }

    }
}
