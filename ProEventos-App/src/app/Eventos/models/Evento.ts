import { Lote } from "./Lote"

export interface Evento {
    id: number,
    local: string,
    dataEvento: Date,
    tema: string,
    QtdPessoa: number,
    ImagemUrl: string,
    Telefone: number,
    email: string
    lote: Lote[]
}