PGDMP     )                    z         
   pencatatan    13.2    13.2     ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    73964 
   pencatatan    DATABASE     j   CREATE DATABASE pencatatan WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_Indonesia.1252';
    DROP DATABASE pencatatan;
                postgres    false            ?            1259    73967    kategori    TABLE     ?   CREATE TABLE public.kategori (
    id_kategori integer NOT NULL,
    nama character varying(30) NOT NULL,
    keterangan character varying(100),
    last_update timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);
    DROP TABLE public.kategori;
       public         heap    postgres    false            ?            1259    73965    kategori_id_kategori_seq    SEQUENCE     ?   CREATE SEQUENCE public.kategori_id_kategori_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.kategori_id_kategori_seq;
       public          postgres    false    201            ?           0    0    kategori_id_kategori_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.kategori_id_kategori_seq OWNED BY public.kategori.id_kategori;
          public          postgres    false    200            ?            1259    73986    note    TABLE     ?   CREATE TABLE public.note (
    id_note integer NOT NULL,
    nama character varying(50),
    kategori integer NOT NULL,
    isi character varying(200) NOT NULL,
    tanggal timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);
    DROP TABLE public.note;
       public         heap    postgres    false            ?            1259    73984    note_id_note_seq    SEQUENCE     ?   CREATE SEQUENCE public.note_id_note_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.note_id_note_seq;
       public          postgres    false    203            ?           0    0    note_id_note_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.note_id_note_seq OWNED BY public.note.id_note;
          public          postgres    false    202            (           2604    73970    kategori id_kategori    DEFAULT     |   ALTER TABLE ONLY public.kategori ALTER COLUMN id_kategori SET DEFAULT nextval('public.kategori_id_kategori_seq'::regclass);
 C   ALTER TABLE public.kategori ALTER COLUMN id_kategori DROP DEFAULT;
       public          postgres    false    201    200    201            *           2604    73989    note id_note    DEFAULT     l   ALTER TABLE ONLY public.note ALTER COLUMN id_note SET DEFAULT nextval('public.note_id_note_seq'::regclass);
 ;   ALTER TABLE public.note ALTER COLUMN id_note DROP DEFAULT;
       public          postgres    false    202    203    203            ?          0    73967    kategori 
   TABLE DATA           N   COPY public.kategori (id_kategori, nama, keterangan, last_update) FROM stdin;
    public          postgres    false    201   {       ?          0    73986    note 
   TABLE DATA           E   COPY public.note (id_note, nama, kategori, isi, tanggal) FROM stdin;
    public          postgres    false    203   ?       ?           0    0    kategori_id_kategori_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.kategori_id_kategori_seq', 5, true);
          public          postgres    false    200            ?           0    0    note_id_note_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.note_id_note_seq', 12, true);
          public          postgres    false    202            -           2606    73972    kategori kategori_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (id_kategori);
 @   ALTER TABLE ONLY public.kategori DROP CONSTRAINT kategori_pkey;
       public            postgres    false    201            /           2606    73992    note note_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.note
    ADD CONSTRAINT note_pkey PRIMARY KEY (id_note);
 8   ALTER TABLE ONLY public.note DROP CONSTRAINT note_pkey;
       public            postgres    false    203            0           2606    73998    note fk_kategori    FK CONSTRAINT     ?   ALTER TABLE ONLY public.note
    ADD CONSTRAINT fk_kategori FOREIGN KEY (kategori) REFERENCES public.kategori(id_kategori) NOT VALID;
 :   ALTER TABLE ONLY public.note DROP CONSTRAINT fk_kategori;
       public          postgres    false    201    203    2861            ?   g   x?3?)MO,?tJ-?,?T(I?+I?KW(????)?YZ???Y??p?rz??U&????&?%f????)?????[??Y???s??qqq S? k      ?   u   x?e?A
?0@?u?sCf??t??t3?Bcb???U?????G???JU?z?(w??dɩ\S??]?K?C???N?a????"??????8 ???࿠u{cnU??~?<?f ??*S     