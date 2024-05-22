
GET /api/rooms должно отдавать Room[]
GET /api/rooms/[id] должно отдавать Room


```ts

export const BED_TYPES = {
  double: {
    title: 'Двуспальная',
  },
  separate: {
    title: 'Отдельная',
  },
}

export type BedType = keyof typeof BED_TYPES

export const ROOM_OPTIONS = {
  'has-safe': {
    title: 'Сейф',
  },
  'has-conditioner': {
    title: 'Кондиционер',
  },
  'has-tub': {
    title: 'Ванная',
  },
  'has-shower': {
    title: 'Душ',
  },
}


export type RoomOption = keyof typeof ROOM_OPTIONS



export interface Room {
  id: string
  title: string
  price: number
  bookedDateRanges: Array<{ start: Date, end: Date }>
  conditions: {
    maxGuests: number
    square: number
    beds: {
      double: number
      single: number
    }
    options: RoomOption[]
  }
  images: {
    preview: RoomImage
    all: RoomImage[]
  }
}

export interface RoomImage {
  id: string
}

```

