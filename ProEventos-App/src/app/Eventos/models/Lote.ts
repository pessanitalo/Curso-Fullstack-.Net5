import { Evento } from "./Evento";

export interface Lote{
    id:number,
    Nome:string,
    Preco: number,
    DataInicio: number,
    Quantidade: number,
    EventoId: number,
    Evento: Evento
}