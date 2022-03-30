import { Lote } from "./Lote"
import { PalestranteEvento } from "./PalestranteEvento"
import { RedeSocial } from "./RedeSocial"

export interface Evento {
    id: number,
    local: string,
    dataEvento: Date,
    tema: string,
    QtdPessoa: number,
    ImagemUrl: string,
    Telefone: number,
    email: string
    lote: Lote[],
    redesSociais: RedeSocial[],
    palestrantesEvemtos: PalestranteEvento[]
}