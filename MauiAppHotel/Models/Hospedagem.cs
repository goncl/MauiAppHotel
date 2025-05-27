﻿namespace MauiAppHotel.Models
{
    public class Hospedagem
    {

        public Quarto QuartoSelecionado { get; set; }

        public int QntAdultos { get; set; }

        public int QntCriancas { get; set; }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valorAdulto = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valorCrianca = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valorAdulto + valorCrianca) * Estadia;

                return total;
            }
        }

    }
}
